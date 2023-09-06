namespace PIC
{
    partial class AuthForm
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
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SignInButton = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(278, 219);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(278, 27);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.Text = "Введите логин";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(278, 280);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(278, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 222);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 280);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(611, 338);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(158, 29);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Войти";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(278, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(278, 34);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(SignInButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "AuthForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Button SignInButton;
        private RichTextBox richTextBox1;
    }
}