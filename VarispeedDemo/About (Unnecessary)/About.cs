using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarispeedDemo.About__Unnecessary_
{
    public partial class About : Form
    {
        public Metadata metadata = new Metadata();
        public About()
        {
            InitializeComponent();
            label1.Text = metadata.WowVersion.ToString();
            if (metadata.WowBranch == "dev")
            {
                label2.Text = "This program is still in development stages...";
            } else if (metadata.WowBranch.Contains("rc"))
            {
                label2.Text = "This is a release candidate, so expect some bugs";
            } else
            {
                label2.Text = "Music player that makes you WOW!";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
