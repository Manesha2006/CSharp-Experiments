using System;
using System.Drawing;
using System.Windows.Forms;

namespace exp5
{
    public partial class Form1 : Form
    {
        Label label;
        TextBox textBox;
        Button button;

        public Form1()
        {
            InitializeComponent();

            label = new Label();
            label.Text = "Enter your name:";
            label.Location = new Point(30, 30);
            label.AutoSize = true;

            textBox = new TextBox();
            textBox.Location = new Point(30, 60);
            textBox.Width = 200;

            button = new Button();
            button.Text = "Click Me";
            button.Location = new Point(30, 100);
            button.Click += Button_Click;

            Controls.Add(label);
            Controls.Add(textBox);
            Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + textBox.Text);
        }
    }
}