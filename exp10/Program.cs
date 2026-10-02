using System;
using System.Drawing;
using System.Windows.Forms;

namespace exp10
{
    public partial class Form1 : Form
    {
        private Button btnOpen;

        public Form1()
        {
            InitializeComponent();

            btnOpen = new Button();
            btnOpen.Text = "Open Dialog";
            btnOpen.Location = new Point(120, 80);
            btnOpen.Size = new Size(130, 40);
            btnOpen.Click += BtnOpen_Click;

            Controls.Add(btnOpen);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();

            dialog.Text = "Custom Dialog";
            dialog.Size = new Size(300, 180);
            dialog.StartPosition = FormStartPosition.CenterParent;

            Label label = new Label();
            label.Text = "Enter your name:";
            label.Location = new Point(30, 30);
            label.AutoSize = true;

            TextBox textBox = new TextBox();
            textBox.Location = new Point(30, 60);
            textBox.Width = 220;

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Location = new Point(100, 100);
            okButton.DialogResult = DialogResult.OK;

            dialog.Controls.Add(label);
            dialog.Controls.Add(textBox);
            dialog.Controls.Add(okButton);

            dialog.ShowDialog();
        }
    }
}