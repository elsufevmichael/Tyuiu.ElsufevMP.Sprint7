
namespace Tyuiu.ElsufevMP.Sprint7.V2
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonSaveFile_EMP = new System.Windows.Forms.Button();
            this.buttonOpenFile_EMP = new System.Windows.Forms.Button();
            this.panelLeft_EMP = new System.Windows.Forms.Panel();
            this.groupBoxButtons_EMP = new System.Windows.Forms.GroupBox();
            this.buttonDelete_EMP = new System.Windows.Forms.Button();
            this.buttonAdd_EMP = new System.Windows.Forms.Button();
            this.buttonEdit_EMP = new System.Windows.Forms.Button();
            this.buttonOpenBase_EMP = new System.Windows.Forms.Button();
            this.openFileDialogTask_EMP = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_EMP = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_EMP = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripTopMenu_EMP = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMain_EMP = new System.Windows.Forms.DataGridView();
            this.panelRight_EMP = new System.Windows.Forms.Panel();
            this.buttonSearch_EMP = new System.Windows.Forms.Button();
            this.pictureBoxImage_EMP = new System.Windows.Forms.PictureBox();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft_EMP.SuspendLayout();
            this.groupBoxButtons_EMP.SuspendLayout();
            this.menuStripTopMenu_EMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_EMP)).BeginInit();
            this.panelRight_EMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage_EMP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveFile_EMP
            // 
            this.buttonSaveFile_EMP.Enabled = false;
            this.buttonSaveFile_EMP.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_EMP.Image")));
            this.buttonSaveFile_EMP.Location = new System.Drawing.Point(103, 8);
            this.buttonSaveFile_EMP.Name = "buttonSaveFile_EMP";
            this.buttonSaveFile_EMP.Size = new System.Drawing.Size(89, 62);
            this.buttonSaveFile_EMP.TabIndex = 0;
            this.toolTipButton_EMP.SetToolTip(this.buttonSaveFile_EMP, "Сохранить базу данных магазинов\r\nВыберите путь для сохранения файла");
            this.buttonSaveFile_EMP.UseVisualStyleBackColor = true;
            this.buttonSaveFile_EMP.Click += new System.EventHandler(this.buttonSaveFile_EMP_Click);
            // 
            // buttonOpenFile_EMP
            // 
            this.buttonOpenFile_EMP.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_EMP.Image")));
            this.buttonOpenFile_EMP.Location = new System.Drawing.Point(8, 8);
            this.buttonOpenFile_EMP.Name = "buttonOpenFile_EMP";
            this.buttonOpenFile_EMP.Size = new System.Drawing.Size(89, 62);
            this.buttonOpenFile_EMP.TabIndex = 0;
            this.toolTipButton_EMP.SetToolTip(this.buttonOpenFile_EMP, "Открыть базу данных магазинов\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_EMP.UseVisualStyleBackColor = true;
            this.buttonOpenFile_EMP.Click += new System.EventHandler(this.buttonOpenFile_EMP_Click);
            // 
            // panelLeft_EMP
            // 
            this.panelLeft_EMP.BackColor = System.Drawing.SystemColors.Window;
            this.panelLeft_EMP.Controls.Add(this.buttonSaveFile_EMP);
            this.panelLeft_EMP.Controls.Add(this.pictureBoxImage_EMP);
            this.panelLeft_EMP.Controls.Add(this.buttonOpenFile_EMP);
            this.panelLeft_EMP.Controls.Add(this.groupBoxButtons_EMP);
            this.panelLeft_EMP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_EMP.Location = new System.Drawing.Point(0, 24);
            this.panelLeft_EMP.Name = "panelLeft_EMP";
            this.panelLeft_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_EMP.Size = new System.Drawing.Size(252, 426);
            this.panelLeft_EMP.TabIndex = 0;
            // 
            // groupBoxButtons_EMP
            // 
            this.groupBoxButtons_EMP.Controls.Add(this.buttonSearch_EMP);
            this.groupBoxButtons_EMP.Controls.Add(this.buttonDelete_EMP);
            this.groupBoxButtons_EMP.Controls.Add(this.buttonAdd_EMP);
            this.groupBoxButtons_EMP.Controls.Add(this.buttonEdit_EMP);
            this.groupBoxButtons_EMP.Controls.Add(this.buttonOpenBase_EMP);
            this.groupBoxButtons_EMP.Location = new System.Drawing.Point(5, 89);
            this.groupBoxButtons_EMP.Name = "groupBoxButtons_EMP";
            this.groupBoxButtons_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxButtons_EMP.Size = new System.Drawing.Size(242, 147);
            this.groupBoxButtons_EMP.TabIndex = 0;
            this.groupBoxButtons_EMP.TabStop = false;
            this.groupBoxButtons_EMP.Text = "Работа с базой данных";
            // 
            // buttonDelete_EMP
            // 
            this.buttonDelete_EMP.Location = new System.Drawing.Point(123, 97);
            this.buttonDelete_EMP.Name = "buttonDelete_EMP";
            this.buttonDelete_EMP.Size = new System.Drawing.Size(93, 23);
            this.buttonDelete_EMP.TabIndex = 0;
            this.buttonDelete_EMP.Text = "Удалить";
            this.toolTipButton_EMP.SetToolTip(this.buttonDelete_EMP, "Удалить магазин и информацию\r\nо нём из базы данных");
            this.buttonDelete_EMP.UseVisualStyleBackColor = true;
            this.buttonDelete_EMP.Visible = false;
            this.buttonDelete_EMP.Click += new System.EventHandler(this.buttonDelete_EMP_Click);
            // 
            // buttonAdd_EMP
            // 
            this.buttonAdd_EMP.Location = new System.Drawing.Point(24, 68);
            this.buttonAdd_EMP.Name = "buttonAdd_EMP";
            this.buttonAdd_EMP.Size = new System.Drawing.Size(93, 23);
            this.buttonAdd_EMP.TabIndex = 0;
            this.buttonAdd_EMP.Text = "Добавить";
            this.toolTipButton_EMP.SetToolTip(this.buttonAdd_EMP, "Добавить магазин и информацию\r\nо нём в базу данных\r\n");
            this.buttonAdd_EMP.UseVisualStyleBackColor = true;
            this.buttonAdd_EMP.Visible = false;
            this.buttonAdd_EMP.Click += new System.EventHandler(this.buttonAdd_EMP_Click);
            // 
            // buttonEdit_EMP
            // 
            this.buttonEdit_EMP.Location = new System.Drawing.Point(24, 97);
            this.buttonEdit_EMP.Name = "buttonEdit_EMP";
            this.buttonEdit_EMP.Size = new System.Drawing.Size(93, 23);
            this.buttonEdit_EMP.TabIndex = 0;
            this.buttonEdit_EMP.Text = "Редактировать";
            this.toolTipButton_EMP.SetToolTip(this.buttonEdit_EMP, "Редактировать информацию\r\nо магазине в базе данных");
            this.buttonEdit_EMP.UseVisualStyleBackColor = true;
            this.buttonEdit_EMP.Visible = false;
            this.buttonEdit_EMP.Click += new System.EventHandler(this.buttonEdit_EMP_Click);
            // 
            // buttonOpenBase_EMP
            // 
            this.buttonOpenBase_EMP.Enabled = false;
            this.buttonOpenBase_EMP.Location = new System.Drawing.Point(61, 21);
            this.buttonOpenBase_EMP.Name = "buttonOpenBase_EMP";
            this.buttonOpenBase_EMP.Size = new System.Drawing.Size(119, 41);
            this.buttonOpenBase_EMP.TabIndex = 0;
            this.buttonOpenBase_EMP.Text = "Вывести данные в таблицу";
            this.buttonOpenBase_EMP.UseVisualStyleBackColor = true;
            this.buttonOpenBase_EMP.Click += new System.EventHandler(this.buttonOpenBase_EMP_Click);
            // 
            // openFileDialogTask_EMP
            // 
            this.openFileDialogTask_EMP.FileName = "openFileDialog1";
            // 
            // toolTipButton_EMP
            // 
            this.toolTipButton_EMP.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_EMP.ToolTipTitle = "Подсказка";
            // 
            // menuStripTopMenu_EMP
            // 
            this.menuStripTopMenu_EMP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStripTopMenu_EMP.Location = new System.Drawing.Point(0, 0);
            this.menuStripTopMenu_EMP.Name = "menuStripTopMenu_EMP";
            this.menuStripTopMenu_EMP.Size = new System.Drawing.Size(772, 24);
            this.menuStripTopMenu_EMP.TabIndex = 2;
            this.menuStripTopMenu_EMP.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.руководствоToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // dataGridViewMain_EMP
            // 
            this.dataGridViewMain_EMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain_EMP.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewMain_EMP.Name = "dataGridViewMain_EMP";
            this.dataGridViewMain_EMP.Size = new System.Drawing.Size(510, 416);
            this.dataGridViewMain_EMP.TabIndex = 0;
            // 
            // panelRight_EMP
            // 
            this.panelRight_EMP.BackColor = System.Drawing.SystemColors.Window;
            this.panelRight_EMP.Controls.Add(this.dataGridViewMain_EMP);
            this.panelRight_EMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_EMP.Location = new System.Drawing.Point(252, 24);
            this.panelRight_EMP.Name = "panelRight_EMP";
            this.panelRight_EMP.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight_EMP.Size = new System.Drawing.Size(520, 426);
            this.panelRight_EMP.TabIndex = 0;
            // 
            // buttonSearch_EMP
            // 
            this.buttonSearch_EMP.Location = new System.Drawing.Point(123, 68);
            this.buttonSearch_EMP.Name = "buttonSearch_EMP";
            this.buttonSearch_EMP.Size = new System.Drawing.Size(93, 23);
            this.buttonSearch_EMP.TabIndex = 1;
            this.buttonSearch_EMP.Text = "Поиск";
            this.toolTipButton_EMP.SetToolTip(this.buttonSearch_EMP, "Найти магазин \r\nв базе данных");
            this.buttonSearch_EMP.UseVisualStyleBackColor = true;
            this.buttonSearch_EMP.Visible = false;
            this.buttonSearch_EMP.Click += new System.EventHandler(this.buttonSearch_EMP_Click);
            // 
            // pictureBoxImage_EMP
            // 
            this.pictureBoxImage_EMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxImage_EMP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage_EMP.Image")));
            this.pictureBoxImage_EMP.Location = new System.Drawing.Point(5, 242);
            this.pictureBoxImage_EMP.Name = "pictureBoxImage_EMP";
            this.pictureBoxImage_EMP.Size = new System.Drawing.Size(242, 184);
            this.pictureBoxImage_EMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage_EMP.TabIndex = 1;
            this.pictureBoxImage_EMP.TabStop = false;
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // руководствоToolStripMenuItem
            // 
            this.руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            this.руководствоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.руководствоToolStripMenuItem.Text = "Руководство";
            this.руководствоToolStripMenuItem.Click += new System.EventHandler(this.руководствоToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.panelRight_EMP);
            this.Controls.Add(this.panelLeft_EMP);
            this.Controls.Add(this.menuStripTopMenu_EMP);
            this.MainMenuStrip = this.menuStripTopMenu_EMP;
            this.MinimumSize = new System.Drawing.Size(788, 489);
            this.Name = "FormMain";
            this.Text = "Спринт 7 | Проект | Вариант 2 | Елсуфьев М. П.";
            this.panelLeft_EMP.ResumeLayout(false);
            this.groupBoxButtons_EMP.ResumeLayout(false);
            this.menuStripTopMenu_EMP.ResumeLayout(false);
            this.menuStripTopMenu_EMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_EMP)).EndInit();
            this.panelRight_EMP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage_EMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft_EMP;
        private System.Windows.Forms.GroupBox groupBoxButtons_EMP;
        private System.Windows.Forms.Button buttonSaveFile_EMP;
        private System.Windows.Forms.Button buttonOpenFile_EMP;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_EMP;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_EMP;
        private System.Windows.Forms.ToolTip toolTipButton_EMP;
        private System.Windows.Forms.MenuStrip menuStripTopMenu_EMP;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpenBase_EMP;
        public System.Windows.Forms.Button buttonDelete_EMP;
        private System.Windows.Forms.Button buttonAdd_EMP;
        private System.Windows.Forms.Button buttonEdit_EMP;
        public System.Windows.Forms.DataGridView dataGridViewMain_EMP;
        private System.Windows.Forms.Panel panelRight_EMP;
        private System.Windows.Forms.Button buttonSearch_EMP;
        private System.Windows.Forms.PictureBox pictureBoxImage_EMP;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоToolStripMenuItem;
    }
}

