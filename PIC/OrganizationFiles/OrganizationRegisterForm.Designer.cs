namespace PIC
{
    partial class OrganizationRegisterForm
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
            LoadOrgRegisterButton = new Button();
            SuspendLayout();
            // 
            // LoadOrgRegisterButton
            // 
            LoadOrgRegisterButton.Location = new Point(456, 228);
            LoadOrgRegisterButton.Name = "LoadOrgRegisterButton";
            LoadOrgRegisterButton.Size = new Size(94, 29);
            LoadOrgRegisterButton.TabIndex = 0;
            LoadOrgRegisterButton.Text = "button1";
            LoadOrgRegisterButton.UseVisualStyleBackColor = true;
            LoadOrgRegisterButton.Click += LoadOrgRegisterButton_Click;
            // 
            // OrganizationRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoadOrgRegisterButton);
            Name = "OrganizationRegisterForm";
            Text = "OrganizationRegisterForm";
            ResumeLayout(false);
        }

        #endregion

        private Button LoadOrgRegisterButton;
    }
}