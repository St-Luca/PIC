﻿namespace PIC
{
    partial class MunicipalContractRegisterForm
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
            LoadMunContractRegisterButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(495, 172);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 0;
            addButton.Text = "button1";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // LoadMunContractRegisterButton
            // 
            LoadMunContractRegisterButton.Location = new Point(468, 265);
            LoadMunContractRegisterButton.Name = "LoadMunContractRegisterButton";
            LoadMunContractRegisterButton.Size = new Size(94, 29);
            LoadMunContractRegisterButton.TabIndex = 1;
            LoadMunContractRegisterButton.Text = "button1";
            LoadMunContractRegisterButton.UseVisualStyleBackColor = true;
            LoadMunContractRegisterButton.Click += LoadMunContractRegisterButton_Click;
            // 
            // MunicipalContractRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoadMunContractRegisterButton);
            Controls.Add(addButton);
            Name = "MunicipalContractRegisterForm";
            Text = "MunicipalContractRegisterForm";
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button LoadMunContractRegisterButton;
    }
}