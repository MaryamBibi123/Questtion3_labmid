namespace Questtion3_labmid
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
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(12, 12);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(260, 20);
            this.textBoxCommand.TabIndex = 0;
            this.textBoxCommand.Text = "Enter command (e.g., Start Right)"; // Set placeholder text as the default text
            this.textBoxCommand.ForeColor = System.Drawing.Color.Gray; // Light gray color for placeholder
            this.textBoxCommand.GotFocus += new System.EventHandler(this.textBoxCommand_GotFocus);
            this.textBoxCommand.LostFocus += new System.EventHandler(this.textBoxCommand_LostFocus);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 38);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 74);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxCommand);
            this.Name = "Form1";
            this.Text = "Remote Car Controller";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelResult;
    }
}
