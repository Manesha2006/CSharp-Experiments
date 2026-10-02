using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowValidation
{
    public partial class Form1 : Form
    {
        private Label lblName;
        private Label lblAge;
        private Label lblEmail;
        private Label lblMobile;

        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtEmail;
        private TextBox txtMobile;

        private Button btnValidate;
        private Button btnClear;

        public Form1()
        {
            InitializeComponent();
            CreateForm();
        }

        private void CreateForm()
        {
            Text = "Window Validation";
            Width = 500;
            Height = 400;
            StartPosition = FormStartPosition.CenterScreen;

            lblName = new Label();
            lblName.Text = "Name";
            lblName.Left = 50;
            lblName.Top = 50;
            lblName.Width = 100;

            txtName = new TextBox();
            txtName.Left = 170;
            txtName.Top = 45;
            txtName.Width = 250;

            lblAge = new Label();
            lblAge.Text = "Age";
            lblAge.Left = 50;
            lblAge.Top = 100;
            lblAge.Width = 100;

            txtAge = new TextBox();
            txtAge.Left = 170;
            txtAge.Top = 95;
            txtAge.Width = 250;

            lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Left = 50;
            lblEmail.Top = 150;
            lblEmail.Width = 100;

            txtEmail = new TextBox();
            txtEmail.Left = 170;
            txtEmail.Top = 145;
            txtEmail.Width = 250;

            lblMobile = new Label();
            lblMobile.Text = "Mobile Number";
            lblMobile.Left = 50;
            lblMobile.Top = 200;
            lblMobile.Width = 100;

            txtMobile = new TextBox();
            txtMobile.Left = 170;
            txtMobile.Top = 195;
            txtMobile.Width = 250;

            btnValidate = new Button();
            btnValidate.Text = "Validate";
            btnValidate.Left = 170;
            btnValidate.Top = 250;
            btnValidate.Width = 100;

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Left = 280;
            btnClear.Top = 250;
            btnClear.Width = 100;

            btnValidate.Click += btnValidate_Click;
            btnClear.Click += btnClear_Click;

            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblMobile);
            Controls.Add(txtMobile);
            Controls.Add(btnValidate);
            Controls.Add(btnClear);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 1 || age > 100)
            {
                MessageBox.Show("Please enter a valid age.");
                txtAge.Focus();
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }

            if (!Regex.IsMatch(txtMobile.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Mobile number must contain 10 digits.");
                txtMobile.Focus();
                return;
            }

            MessageBox.Show(
                "Validation Successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtName.Focus();
        }
    }
}