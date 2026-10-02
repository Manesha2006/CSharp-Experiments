using System;
using System.Windows.Forms;

namespace exp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = new Form();
            child.Text = "Child Form";
            child.MdiParent = this;
            child.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}