
namespace Tyuiu.ElsufevMP.Sprint7.V2
{
    partial class FormSearch
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
            this.comboBoxSearchFilter_EMP = new System.Windows.Forms.ComboBox();
            this.labelSearchFilter_EMP = new System.Windows.Forms.Label();
            this.labelFind_EMP = new System.Windows.Forms.Label();
            this.textBoxFind_EMP = new System.Windows.Forms.TextBox();
            this.buttonFind_EMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSearchFilter_EMP
            // 
            this.comboBoxSearchFilter_EMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchFilter_EMP.FormattingEnabled = true;
            this.comboBoxSearchFilter_EMP.Items.AddRange(new object[] {
            "Номеру",
            "Названию",
            "Адресу",
            "Телефон магазина"});
            this.comboBoxSearchFilter_EMP.Location = new System.Drawing.Point(76, 9);
            this.comboBoxSearchFilter_EMP.Name = "comboBoxSearchFilter_EMP";
            this.comboBoxSearchFilter_EMP.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSearchFilter_EMP.TabIndex = 0;
            // 
            // labelSearchFilter_EMP
            // 
            this.labelSearchFilter_EMP.AutoSize = true;
            this.labelSearchFilter_EMP.Location = new System.Drawing.Point(13, 12);
            this.labelSearchFilter_EMP.Name = "labelSearchFilter_EMP";
            this.labelSearchFilter_EMP.Size = new System.Drawing.Size(50, 13);
            this.labelSearchFilter_EMP.TabIndex = 1;
            this.labelSearchFilter_EMP.Text = "Фильтр:";
            // 
            // labelFind_EMP
            // 
            this.labelFind_EMP.AutoSize = true;
            this.labelFind_EMP.Location = new System.Drawing.Point(277, 12);
            this.labelFind_EMP.Name = "labelFind_EMP";
            this.labelFind_EMP.Size = new System.Drawing.Size(39, 13);
            this.labelFind_EMP.TabIndex = 2;
            this.labelFind_EMP.Text = "Поиск";
            // 
            // textBoxFind_EMP
            // 
            this.textBoxFind_EMP.Location = new System.Drawing.Point(322, 9);
            this.textBoxFind_EMP.Name = "textBoxFind_EMP";
            this.textBoxFind_EMP.Size = new System.Drawing.Size(179, 20);
            this.textBoxFind_EMP.TabIndex = 3;
            // 
            // buttonFind_EMP
            // 
            this.buttonFind_EMP.Location = new System.Drawing.Point(426, 54);
            this.buttonFind_EMP.Name = "buttonFind_EMP";
            this.buttonFind_EMP.Size = new System.Drawing.Size(75, 23);
            this.buttonFind_EMP.TabIndex = 4;
            this.buttonFind_EMP.Text = "Найти";
            this.buttonFind_EMP.UseVisualStyleBackColor = true;
            this.buttonFind_EMP.Click += new System.EventHandler(this.buttonFind_EMP_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(514, 89);
            this.Controls.Add(this.buttonFind_EMP);
            this.Controls.Add(this.textBoxFind_EMP);
            this.Controls.Add(this.labelFind_EMP);
            this.Controls.Add(this.labelSearchFilter_EMP);
            this.Controls.Add(this.comboBoxSearchFilter_EMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearchFilter_EMP;
        private System.Windows.Forms.Label labelSearchFilter_EMP;
        private System.Windows.Forms.Label labelFind_EMP;
        private System.Windows.Forms.TextBox textBoxFind_EMP;
        private System.Windows.Forms.Button buttonFind_EMP;
    }
}