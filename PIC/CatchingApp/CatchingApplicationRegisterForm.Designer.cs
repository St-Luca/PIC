namespace PIC
{
    partial class CatchingApplicationRegisterForm
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
            addButton = new Button();
            LoadCatAppRegButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(527, 194);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 0;
            addButton.Text = "button1";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // LoadCatAppRegButton
            // 
            LoadCatAppRegButton.Location = new Point(333, 326);
            LoadCatAppRegButton.Name = "LoadCatAppRegButton";
            LoadCatAppRegButton.Size = new Size(94, 29);
            LoadCatAppRegButton.TabIndex = 1;
            LoadCatAppRegButton.Text = "button1";
            LoadCatAppRegButton.UseVisualStyleBackColor = true;
            LoadCatAppRegButton.Click += LoadCatAppRegButton_Click;
            // 
            // CatchingApplicationRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoadCatAppRegButton);
            Controls.Add(addButton);
            Name = "CatchingApplicationRegisterForm";
            Text = "CatchingApplicationRegisterForm";
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button LoadCatAppRegButton;
    }
}