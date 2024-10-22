using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ExperienceView : UserControl
    {
        public ExperienceView()
        {
            InitializeComponent();
            SetStyle();
        }

        private void SetStyle()
        {
            // Segoe MDL2 Assets
            btnBack.Text = "\uE72B";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchView.GoBack(this.Parent as Panel);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/builtbybel/xd-AntiSpy/tree/main/plugins");
        }
    }
}