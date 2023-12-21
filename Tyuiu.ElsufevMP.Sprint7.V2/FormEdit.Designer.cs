
namespace Tyuiu.ElsufevMP.Sprint7.V2
{
    partial class FormEdit
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
            this.labelNumber_EMP = new System.Windows.Forms.Label();
            this.labelName_EMP = new System.Windows.Forms.Label();
            this.labelAddress_EMP = new System.Windows.Forms.Label();
            this.labelPhoneNumber_EMP = new System.Windows.Forms.Label();
            this.textBoxNumber_EMP = new System.Windows.Forms.TextBox();
            this.textBoxName_EMP = new System.Windows.Forms.TextBox();
            this.textBoxAddress_EMP = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber_EMP = new System.Windows.Forms.TextBox();
            this.buttonEdit_EMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber_EMP
            // 
            this.labelNumber_EMP.AutoSize = true;
            this.labelNumber_EMP.Location = new System.Drawing.Point(13, 13);
            this.labelNumber_EMP.Name = "labelNumber_EMP";
            this.labelNumber_EMP.Size = new System.Drawing.Size(74, 26);
            this.labelNumber_EMP.TabIndex = 0;
            this.labelNumber_EMP.Text = "Порядковый \r\nномер\r\n";
            // 
            // labelName_EMP
            // 
            this.labelName_EMP.AutoSize = true;
            this.labelName_EMP.Location = new System.Drawing.Point(12, 47);
            this.labelName_EMP.Name = "labelName_EMP";
            this.labelName_EMP.Size = new System.Drawing.Size(57, 26);
            this.labelName_EMP.TabIndex = 0;
            this.labelName_EMP.Text = "Название\r\nмагазина";
            // 
            // labelAddress_EMP
            // 
            this.labelAddress_EMP.AutoSize = true;
            this.labelAddress_EMP.Location = new System.Drawing.Point(12, 84);
            this.labelAddress_EMP.Name = "labelAddress_EMP";
            this.labelAddress_EMP.Size = new System.Drawing.Size(56, 26);
            this.labelAddress_EMP.TabIndex = 0;
            this.labelAddress_EMP.Text = "Адрес\r\nмагазина";
            // 
            // labelPhoneNumber_EMP
            // 
            this.labelPhoneNumber_EMP.AutoSize = true;
            this.labelPhoneNumber_EMP.Location = new System.Drawing.Point(12, 121);
            this.labelPhoneNumber_EMP.Name = "labelPhoneNumber_EMP";
            this.labelPhoneNumber_EMP.Size = new System.Drawing.Size(56, 26);
            this.labelPhoneNumber_EMP.TabIndex = 0;
            this.labelPhoneNumber_EMP.Text = "Телефон\r\nмагазина";
            // 
            // textBoxNumber_EMP
            // 
            this.textBoxNumber_EMP.Location = new System.Drawing.Point(97, 12);
            this.textBoxNumber_EMP.Name = "textBoxNumber_EMP";
            this.textBoxNumber_EMP.Size = new System.Drawing.Size(210, 20);
            this.textBoxNumber_EMP.TabIndex = 1;
            // 
            // textBoxName_EMP
            // 
            this.textBoxName_EMP.Location = new System.Drawing.Point(97, 47);
            this.textBoxName_EMP.Name = "textBoxName_EMP";
            this.textBoxName_EMP.Size = new System.Drawing.Size(210, 20);
            this.textBoxName_EMP.TabIndex = 1;
            // 
            // textBoxAddress_EMP
            // 
            this.textBoxAddress_EMP.Location = new System.Drawing.Point(97, 84);
            this.textBoxAddress_EMP.Name = "textBoxAddress_EMP";
            this.textBoxAddress_EMP.Size = new System.Drawing.Size(210, 20);
            this.textBoxAddress_EMP.TabIndex = 1;
            // 
            // textBoxPhoneNumber_EMP
            // 
            this.textBoxPhoneNumber_EMP.Location = new System.Drawing.Point(97, 121);
            this.textBoxPhoneNumber_EMP.Name = "textBoxPhoneNumber_EMP";
            this.textBoxPhoneNumber_EMP.Size = new System.Drawing.Size(210, 20);
            this.textBoxPhoneNumber_EMP.TabIndex = 1;
            // 
            // buttonEdit_EMP
            // 
            this.buttonEdit_EMP.Location = new System.Drawing.Point(232, 166);
            this.buttonEdit_EMP.Name = "buttonEdit_EMP";
            this.buttonEdit_EMP.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit_EMP.TabIndex = 2;
            this.buttonEdit_EMP.Text = "Изменить";
            this.buttonEdit_EMP.UseVisualStyleBackColor = true;
            this.buttonEdit_EMP.Click += new System.EventHandler(this.buttonEdit_EMP_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(319, 201);
            this.Controls.Add(this.buttonEdit_EMP);
            this.Controls.Add(this.textBoxPhoneNumber_EMP);
            this.Controls.Add(this.textBoxAddress_EMP);
            this.Controls.Add(this.textBoxName_EMP);
            this.Controls.Add(this.textBoxNumber_EMP);
            this.Controls.Add(this.labelPhoneNumber_EMP);
            this.Controls.Add(this.labelAddress_EMP);
            this.Controls.Add(this.labelName_EMP);
            this.Controls.Add(this.labelNumber_EMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber_EMP;
        private System.Windows.Forms.Label labelName_EMP;
        private System.Windows.Forms.Label labelAddress_EMP;
        private System.Windows.Forms.Label labelPhoneNumber_EMP;
        public System.Windows.Forms.TextBox textBoxNumber_EMP;
        public System.Windows.Forms.TextBox textBoxName_EMP;
        public System.Windows.Forms.TextBox textBoxAddress_EMP;
        public System.Windows.Forms.TextBox textBoxPhoneNumber_EMP;
        private System.Windows.Forms.Button buttonEdit_EMP;
    }
}