namespace exp10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            ClientSize = new System.Drawing.Size(400, 250);
            Name = "Form1";
            Text = "Custom Dialog Box";

            ResumeLayout(false);
        }
    }
}