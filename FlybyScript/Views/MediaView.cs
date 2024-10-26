using FlybyScript;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class MediaView : UserControl
    {
        private USBManagement usbManagement;
        private Logger logger;

        private string selectedIsoPath;

        public MediaView()
        {
            InitializeComponent();
            SetStyle();

            InitializeUSBDriveList();
            logger = new Logger(rtbLog);
            usbManagement = new USBManagement(logger, updateLabelStatus, progressBar);
        }

        private void SetStyle()
        {
            // Segoe MDL2 Assets
            btnBack.Text = "\uE72B";
        }

        private void updateLabelStatus(string statusText)
        {
            if (lblStatus.InvokeRequired)
            {
                lblStatus.Invoke(new Action(() => lblStatus.Text = statusText));
            }
            else
            {
                lblStatus.Text = statusText;
            }
        }

        private void InitializeUSBDriveList()
        {
            // Initialize disk numbers
            comboBoxDrives.Items.Clear();
            comboBoxDrives.Items.AddRange(new object[] { "Select (e.g., 1, 2, 3...)", "1", "2", "3" });
            comboBoxDrives.SelectedIndex = 0;

            // Initialize removable drives
            comboBoxDriveLetters.Items.Clear();
            var removableDrives = DriveInfo.GetDrives()
                                           .Where(d => d.DriveType == DriveType.Removable)
                                           .Select(d => d.Name)
                                           .ToArray();

            if (removableDrives.Any())
            {
                comboBoxDriveLetters.Items.AddRange(removableDrives);
                comboBoxDriveLetters.SelectedIndex = 0;
            }
            else
            {
                //MessageBox.Show("No removable drives found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxDriveLetters.Enabled =
                comboBoxDrives.Enabled = false;
            }
        }

        private async Task ShowDiskList()
        {
            try
            {
                // Use chcp command to get the current code page of the user's system
                ProcessStartInfo chcpInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/C chcp",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                string codePageOutput;
                using (Process chcpProcess = Process.Start(chcpInfo))
                {
                    codePageOutput = await chcpProcess.StandardOutput.ReadToEndAsync();
                    chcpProcess.WaitForExit();
                }

                // Extract the code page number from chcp output
                int codePage = 850; // Default to 850 if detection fails
                var match = System.Text.RegularExpressions.Regex.Match(codePageOutput, @"\d+");
                if (match.Success)
                {
                    codePage = int.Parse(match.Value); // Parse our detected code page
                }

                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "diskpart.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.GetEncoding(codePage)
                };

                // Start the process
                using (Process process = Process.Start(processInfo))
                {
                    using (StreamWriter writer = process.StandardInput)
                    {
                        if (writer.BaseStream.CanWrite)
                        {
                            writer.WriteLine("list disk");
                        }
                    }

                    string output = await process.StandardOutput.ReadToEndAsync();
                    process.WaitForExit();
                    MessageBox.Show(output, "Available Disks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while listing disks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for starting the format and copy process
        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false; // Disable the Start button

            // Validate Disk Number
            if (string.IsNullOrEmpty(comboBoxDrives.Text) || !int.TryParse(comboBoxDrives.Text, out _))
            {
                logger.Log("Please enter a valid Disk Number.", Color.Red);
                btnStart.Enabled = true; // Re-enable the button
                return;
            }

            // Validate Drive Letter
            if (string.IsNullOrEmpty(comboBoxDriveLetters.SelectedItem?.ToString()))
            {
                logger.Log("Please select a valid Drive Letter.", Color.Red);
                btnStart.Enabled = true;
                return;
            }

            string diskNumber = comboBoxDrives.Text.Trim(); // Get the disk number from the ComboBox
            string driveLetter = comboBoxDriveLetters.SelectedItem.ToString().Trim(); // Get the selected drive letter

            logger.Log($"Starting to format Disk {diskNumber} and copy to Drive {driveLetter}...", Color.Black);

            try
            {
                // Format the drive using the disk number
                await usbManagement.FormatDriveAsync(diskNumber); // Pass the disk number
                logger.Log($"Disk {diskNumber} formatted successfully.", Color.Black);
                logger.Log($"Disk {diskNumber} is now bootable.", Color.Black);

                // Copy ISO and create unattend.xml if checked
                bool createUnattend = checkCreateUnattend.Checked;
                await usbManagement.CopyISOWithUnattendAsync(driveLetter, selectedIsoPath, createUnattend); // Use the drive letter for copying

                logger.Log("Process completed!", Color.Green);
            }
            catch (Exception ex)
            {
                logger.Log($"An error occurred during the process: {ex.Message}", Color.Red);
            }
            finally
            {
                btnStart.Enabled = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ISO Files (*.iso)|*.iso|All Files (*.*)|*.*";
                openFileDialog.Title = "Select an ISO File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedIsoPath = openFileDialog.FileName;
                    logger.Log($"Selected ISO file: {selectedIsoPath}", Color.Black);

                    checkCreateUnattend.Visible = true; // Show the checkbox to create unattend.xml
                }
                else
                {
                    logger.Log("ISO file selection was cancelled.", Color.Red);
                }
            }
        }

        private void checkCreateUnattend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCreateUnattend.Checked)
            {
                checkCreateUnattend.BackColor = Color.LightGreen;

                MessageBox.Show(
                    "You have enabled the bypass for Windows 11 hardware requirements.\n\n" +
                    "This will: \n" +
                    "- Skip TPM 2.0 checks\n" +
                    "- Bypass the 4GB+ RAM requirement\n" +
                    "- Disable Secure Boot requirement\n" +
                    "- Allow creating a local account (no online setup required)\n\n" +
                    "During installation, Windows will offer the 'I don't have internet' option for offline account creation.",
                    "Bypass Enabled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                checkCreateUnattend.BackColor = Color.White;
            }
        }

        private async void linkShowDiskList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await ShowDiskList();
        }

        private async void btnMCT_Click(object sender, EventArgs e)
        {
            await usbManagement.DownloadMediaCreationTool();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchView.GoBack(this.Parent as Panel);
        }
    }
}