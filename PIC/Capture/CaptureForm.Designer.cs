namespace PIC
{
    partial class CaptureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoadCaptureRegisterButton = new Button();
            AddCaptureButton = new Button();
            SuspendLayout();
            // 
            // LoadCaptureRegisterButton
            // 
            LoadCaptureRegisterButton.Location = new Point(504, 211);
            LoadCaptureRegisterButton.Name = "LoadCaptureRegisterButton";
            LoadCaptureRegisterButton.Size = new Size(94, 29);
            LoadCaptureRegisterButton.TabIndex = 0;
            LoadCaptureRegisterButton.Text = "button1";
            LoadCaptureRegisterButton.UseVisualStyleBackColor = true;
            LoadCaptureRegisterButton.Click += LoadCaptureRegisterButton_Click;
            // 
            // AddCaptureButton
            // 
            AddCaptureButton.Location = new Point(515, 103);
            AddCaptureButton.Name = "AddCaptureButton";
            AddCaptureButton.Size = new Size(94, 29);
            AddCaptureButton.TabIndex = 1;
            AddCaptureButton.Text = "button1";
            AddCaptureButton.UseVisualStyleBackColor = true;
            AddCaptureButton.Click += AddCaptureButton_Click;
            // 
            // CaptureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddCaptureButton);
            Controls.Add(LoadCaptureRegisterButton);
            Name = "CaptureForm";
            Text = "CaptureForm";
            ResumeLayout(false);
        }

        #endregion

        private Button LoadCaptureRegisterButton;
        private Button AddCaptureButton;
    }
}