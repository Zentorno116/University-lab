namespace University_lab
{
    partial class Main_Form

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
            menuStrip1 = new MenuStrip();
            lToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { lToolStripMenuItem, изменитьToolStripMenuItem, удалитьToolStripMenuItem, выйтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // lToolStripMenuItem
            // 
            lToolStripMenuItem.DoubleClickEnabled = true;
            lToolStripMenuItem.Name = "lToolStripMenuItem";
            lToolStripMenuItem.Size = new Size(90, 24);
            lToolStripMenuItem.Text = "Добавить";
;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(92, 24);
            изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(79, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(67, 24);
            выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Name, City });
            dataGridView1.Location = new Point(0, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 383);
            dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Название";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // City
            // 
            City.HeaderText = "Город";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.Width = 125;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Казань", "Москва", "Санкт-Петербург" });
            comboBox1.Location = new Point(12, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            //Name = "Main_Form";
            Text = "Главная форма";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn City;
    }
}
