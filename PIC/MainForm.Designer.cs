namespace PIC
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            реестрыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            реестрыToolStripMenuItem1 = new ToolStripMenuItem();
            контрактыToolStripMenuItem = new ToolStripMenuItem();
            задатьСортировкуToolStripMenuItem = new ToolStripMenuItem();
            задатьФильтрToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            заявкиToolStripMenuItem = new ToolStripMenuItem();
            задатьФильтрToolStripMenuItem1 = new ToolStripMenuItem();
            задатьФильтрToolStripMenuItem2 = new ToolStripMenuItem();
            поискToolStripMenuItem1 = new ToolStripMenuItem();
            актыToolStripMenuItem = new ToolStripMenuItem();
            задатьСортировкуToolStripMenuItem1 = new ToolStripMenuItem();
            задатьФильтрToolStripMenuItem3 = new ToolStripMenuItem();
            поискToolStripMenuItem2 = new ToolStripMenuItem();
            добавлениеToolStripMenuItem = new ToolStripMenuItem();
            изменениеToolStripMenuItem = new ToolStripMenuItem();
            удалениеToolStripMenuItem = new ToolStripMenuItem();
            отчетToolStripMenuItem = new ToolStripMenuItem();
            организацииToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 405);
            dataGridView1.TabIndex = 0;
            // 
            // реестрыToolStripMenuItem
            // 
            реестрыToolStripMenuItem.Name = "реестрыToolStripMenuItem";
            реестрыToolStripMenuItem.Size = new Size(120, 22);
            реестрыToolStripMenuItem.Text = "Реестры";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { реестрыToolStripMenuItem1, добавлениеToolStripMenuItem, изменениеToolStripMenuItem, удалениеToolStripMenuItem, отчетToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // реестрыToolStripMenuItem1
            // 
            реестрыToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { контрактыToolStripMenuItem, заявкиToolStripMenuItem, актыToolStripMenuItem, организацииToolStripMenuItem });
            реестрыToolStripMenuItem1.Name = "реестрыToolStripMenuItem1";
            реестрыToolStripMenuItem1.Size = new Size(80, 24);
            реестрыToolStripMenuItem1.Text = "Реестры";
            // 
            // контрактыToolStripMenuItem
            // 
            контрактыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { задатьСортировкуToolStripMenuItem, задатьФильтрToolStripMenuItem, поискToolStripMenuItem });
            контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            контрактыToolStripMenuItem.Size = new Size(224, 26);
            контрактыToolStripMenuItem.Text = "Контракты";
            контрактыToolStripMenuItem.Click += контрактыToolStripMenuItem_Click;
            // 
            // задатьСортировкуToolStripMenuItem
            // 
            задатьСортировкуToolStripMenuItem.Name = "задатьСортировкуToolStripMenuItem";
            задатьСортировкуToolStripMenuItem.Size = new Size(222, 26);
            задатьСортировкуToolStripMenuItem.Text = "Задать сортировку";
            // 
            // задатьФильтрToolStripMenuItem
            // 
            задатьФильтрToolStripMenuItem.Name = "задатьФильтрToolStripMenuItem";
            задатьФильтрToolStripMenuItem.Size = new Size(222, 26);
            задатьФильтрToolStripMenuItem.Text = "Задать фильтр";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(222, 26);
            поискToolStripMenuItem.Text = "Поиск";
            // 
            // заявкиToolStripMenuItem
            // 
            заявкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { задатьФильтрToolStripMenuItem1, задатьФильтрToolStripMenuItem2, поискToolStripMenuItem1 });
            заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            заявкиToolStripMenuItem.Size = new Size(224, 26);
            заявкиToolStripMenuItem.Text = "Заявки";
            // 
            // задатьФильтрToolStripMenuItem1
            // 
            задатьФильтрToolStripMenuItem1.Name = "задатьФильтрToolStripMenuItem1";
            задатьФильтрToolStripMenuItem1.Size = new Size(222, 26);
            задатьФильтрToolStripMenuItem1.Text = "Задать сортировку";
            // 
            // задатьФильтрToolStripMenuItem2
            // 
            задатьФильтрToolStripMenuItem2.Name = "задатьФильтрToolStripMenuItem2";
            задатьФильтрToolStripMenuItem2.Size = new Size(222, 26);
            задатьФильтрToolStripMenuItem2.Text = "Задать фильтр";
            // 
            // поискToolStripMenuItem1
            // 
            поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            поискToolStripMenuItem1.Size = new Size(222, 26);
            поискToolStripMenuItem1.Text = "Поиск";
            // 
            // актыToolStripMenuItem
            // 
            актыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { задатьСортировкуToolStripMenuItem1, задатьФильтрToolStripMenuItem3, поискToolStripMenuItem2 });
            актыToolStripMenuItem.Name = "актыToolStripMenuItem";
            актыToolStripMenuItem.Size = new Size(224, 26);
            актыToolStripMenuItem.Text = "Акты";
            // 
            // задатьСортировкуToolStripMenuItem1
            // 
            задатьСортировкуToolStripMenuItem1.Name = "задатьСортировкуToolStripMenuItem1";
            задатьСортировкуToolStripMenuItem1.Size = new Size(222, 26);
            задатьСортировкуToolStripMenuItem1.Text = "Задать сортировку";
            // 
            // задатьФильтрToolStripMenuItem3
            // 
            задатьФильтрToolStripMenuItem3.Name = "задатьФильтрToolStripMenuItem3";
            задатьФильтрToolStripMenuItem3.Size = new Size(222, 26);
            задатьФильтрToolStripMenuItem3.Text = "Задать фильтр";
            // 
            // поискToolStripMenuItem2
            // 
            поискToolStripMenuItem2.Name = "поискToolStripMenuItem2";
            поискToolStripMenuItem2.Size = new Size(222, 26);
            поискToolStripMenuItem2.Text = "Поиск";
            // 
            // добавлениеToolStripMenuItem
            // 
            добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            добавлениеToolStripMenuItem.Size = new Size(109, 24);
            добавлениеToolStripMenuItem.Text = "Добавление";
            // 
            // изменениеToolStripMenuItem
            // 
            изменениеToolStripMenuItem.Name = "изменениеToolStripMenuItem";
            изменениеToolStripMenuItem.Size = new Size(103, 24);
            изменениеToolStripMenuItem.Text = "Изменение";
            // 
            // удалениеToolStripMenuItem
            // 
            удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            удалениеToolStripMenuItem.Size = new Size(90, 24);
            удалениеToolStripMenuItem.Text = "Удаление";
            // 
            // отчетToolStripMenuItem
            // 
            отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            отчетToolStripMenuItem.Size = new Size(62, 24);
            отчетToolStripMenuItem.Text = "Отчет";
            // 
            // организацииToolStripMenuItem
            // 
            организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            организацииToolStripMenuItem.Size = new Size(224, 26);
            организацииToolStripMenuItem.Text = "Организации";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStripMenuItem реестрыToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem реестрыToolStripMenuItem1;
        private ToolStripMenuItem контрактыToolStripMenuItem;
        private ToolStripMenuItem задатьСортировкуToolStripMenuItem;
        private ToolStripMenuItem задатьФильтрToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem заявкиToolStripMenuItem;
        private ToolStripMenuItem задатьФильтрToolStripMenuItem1;
        private ToolStripMenuItem задатьФильтрToolStripMenuItem2;
        private ToolStripMenuItem поискToolStripMenuItem1;
        private ToolStripMenuItem актыToolStripMenuItem;
        private ToolStripMenuItem задатьСортировкуToolStripMenuItem1;
        private ToolStripMenuItem задатьФильтрToolStripMenuItem3;
        private ToolStripMenuItem поискToolStripMenuItem2;
        private ToolStripMenuItem добавлениеToolStripMenuItem;
        private ToolStripMenuItem изменениеToolStripMenuItem;
        private ToolStripMenuItem удалениеToolStripMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private ToolStripMenuItem организацииToolStripMenuItem;
    }
}