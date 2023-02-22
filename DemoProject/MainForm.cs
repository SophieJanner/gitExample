using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            btnClickThis.BackColor = Color.Blue;
            btnClickThis.ForeColor = Color.White;
        }

        private void btnCountPresses_Click(object sender, EventArgs e)
        {
            int currentCount = int.Parse(lblCount.Text);

            lblCount.Text = (currentCount + 1).ToString();
        }

        private void btnEndProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
