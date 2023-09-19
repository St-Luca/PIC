namespace PIC
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
            dataGridView1 = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            ConclusionDateColumn = new DataGridViewTextBoxColumn();
            EffectiveDateColumn = new DataGridViewTextBoxColumn();
            PerformerColumn = new DataGridViewTextBoxColumn();
            CustomerColumn = new DataGridViewTextBoxColumn();
            LocalitiesColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(1124, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 0;
            addButton.Text = "button1";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // LoadMunContractRegisterButton
            // 
            LoadMunContractRegisterButton.Location = new Point(1124, 62);
            LoadMunContractRegisterButton.Name = "LoadMunContractRegisterButton";
            LoadMunContractRegisterButton.Size = new Size(94, 29);
            LoadMunContractRegisterButton.TabIndex = 1;
            LoadMunContractRegisterButton.Text = "button1";
            LoadMunContractRegisterButton.UseVisualStyleBackColor = true;
            LoadMunContractRegisterButton.Click += LoadMunContractRegisterButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdColumn, ConclusionDateColumn, EffectiveDateColumn, PerformerColumn, CustomerColumn, LocalitiesColumn, PriceColumn });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1106, 444);
            dataGridView1.TabIndex = 2;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.Width = 125;
            // 
            // ConclusionDateColumn
            // 
            ConclusionDateColumn.DataPropertyName = "ConclusionDate";
            ConclusionDateColumn.HeaderText = "Дата заключения";
            ConclusionDateColumn.MinimumWidth = 6;
            ConclusionDateColumn.Name = "ConclusionDateColumn";
            ConclusionDateColumn.Width = 125;
            // 
            // EffectiveDateColumn
            // 
            EffectiveDateColumn.DataPropertyName = "EffectiveDate";
            EffectiveDateColumn.HeaderText = "Дата окончания";
            EffectiveDateColumn.MinimumWidth = 6;
            EffectiveDateColumn.Name = "EffectiveDateColumn";
            EffectiveDateColumn.Width = 125;
            // 
            // PerformerColumn
            // 
            PerformerColumn.DataPropertyName = "Performer";
            PerformerColumn.HeaderText = "Исполнитель";
            PerformerColumn.MinimumWidth = 6;
            PerformerColumn.Name = "PerformerColumn";
            PerformerColumn.Width = 125;
            // 
            // CustomerColumn
            // 
            CustomerColumn.DataPropertyName = "Customer";
            CustomerColumn.HeaderText = "Заказчик";
            CustomerColumn.MinimumWidth = 6;
            CustomerColumn.Name = "CustomerColumn";
            CustomerColumn.Width = 125;
            // 
            // LocalitiesColumn
            // 
            LocalitiesColumn.DataPropertyName = "Localities";
            LocalitiesColumn.HeaderText = "Список населенных пунктов";
            LocalitiesColumn.MinimumWidth = 6;
            LocalitiesColumn.Name = "LocalitiesColumn";
            LocalitiesColumn.Width = 125;
            // 
            // PriceColumn
            // 
            PriceColumn.DataPropertyName = "Price";
            PriceColumn.HeaderText = "Цена за животное";
            PriceColumn.MinimumWidth = 6;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.Width = 125;
            // 
            // MunicipalContractRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 450);
            Controls.Add(dataGridView1);
            Controls.Add(LoadMunContractRegisterButton);
            Controls.Add(addButton);
            Name = "MunicipalContractRegisterForm";
            Text = "MunicipalContractRegisterForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private Button LoadMunContractRegisterButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn ConclusionDateColumn;
        private DataGridViewTextBoxColumn EffectiveDateColumn;
        private DataGridViewTextBoxColumn PerformerColumn;
        private DataGridViewTextBoxColumn CustomerColumn;
        private DataGridViewTextBoxColumn LocalitiesColumn;
        private DataGridViewTextBoxColumn PriceColumn;
    }
}