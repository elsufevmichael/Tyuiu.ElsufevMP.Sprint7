
namespace Tyuiu.ElsufevMP.Sprint7.V2
{
    partial class FormAdd
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
            this.textBoxNumber_EMP = new System.Windows.Forms.TextBox();
            this.labelName_EMP = new System.Windows.Forms.Label();
            this.labelAddress_EMP = new System.Windows.Forms.Label();
            this.labelPhoneNumber_EMP = new System.Windows.Forms.Label();
            this.textBoxName_EMP = new System.Windows.Forms.TextBox();
            this.textBoxAddress_EMP = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber_EMP = new System.Windows.Forms.TextBox();
            this.buttonAdd_EMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber_EMP
            // 
            this.labelNumber_EMP.AutoSize = true;
            this.labelNumber_EMP.Location = new System.Drawing.Point(13, 13);
            this.labelNumber_EMP.Name = "labelNumber_EMP";
            this.labelNumber_EMP.Size = new System.Drawing.Size(74, 26);
            this.labelNumber_EMP.TabIndex = 0;
            this.labelNumber_EMP.Text = "Порядковый \r\nномер";
            // 
            // textBoxNumber_EMP
            // 
            this.textBoxNumber_EMP.Location = new System.Drawing.Point(99, 19);
            this.textBoxNumber_EMP.Name = "textBoxNumber_EMP";
            this.textBoxNumber_EMP.Size = new System.Drawing.Size(198, 20);
            this.textBoxNumber_EMP.TabIndex = 1;
            // 
            // labelName_EMP
            // 
            this.labelName_EMP.AutoSize = true;
            this.labelName_EMP.Location = new System.Drawing.Point(12, 50);
            this.labelName_EMP.Name = "labelName_EMP";
            this.labelName_EMP.Size = new System.Drawing.Size(57, 26);
            this.labelName_EMP.TabIndex = 0;
            this.labelName_EMP.Text = "Название\r\nмагазина";
            // 
            // labelAddress_EMP
            // 
            this.labelAddress_EMP.AutoSize = true;
            this.labelAddress_EMP.Location = new System.Drawing.Point(12, 88);
            this.labelAddress_EMP.Name = "labelAddress_EMP";
            this.labelAddress_EMP.Size = new System.Drawing.Size(56, 26);
            this.labelAddress_EMP.TabIndex = 0;
            this.labelAddress_EMP.Text = "Адрес\r\nмагазина";
            // 
            // labelPhoneNumber_EMP
            // 
            this.labelPhoneNumber_EMP.AutoSize = true;
            this.labelPhoneNumber_EMP.Location = new System.Drawing.Point(12, 126);
            this.labelPhoneNumber_EMP.Name = "labelPhoneNumber_EMP";
            this.labelPhoneNumber_EMP.Size = new System.Drawing.Size(56, 26);
            this.labelPhoneNumber_EMP.TabIndex = 0;
            this.labelPhoneNumber_EMP.Text = "Телефон\r\nмагазина\r\n";
            // 
            // textBoxName_EMP
            // 
            this.textBoxName_EMP.Location = new System.Drawing.Point(99, 56);
            this.textBoxName_EMP.Name = "textBoxName_EMP";
            this.textBoxName_EMP.Size = new System.Drawing.Size(198, 20);
            this.textBoxName_EMP.TabIndex = 1;
            // 
            // textBoxAddress_EMP
            // 
            this.textBoxAddress_EMP.Location = new System.Drawing.Point(99, 94);
            this.textBoxAddress_EMP.Name = "textBoxAddress_EMP";
            this.textBoxAddress_EMP.Size = new System.Drawing.Size(198, 20);
            this.textBoxAddress_EMP.TabIndex = 1;
            // 
            // textBoxPhoneNumber_EMP
            // 
            this.textBoxPhoneNumber_EMP.Location = new System.Drawing.Point(99, 132);
            this.textBoxPhoneNumber_EMP.Name = "textBoxPhoneNumber_EMP";
            this.textBoxPhoneNumber_EMP.Size = new System.Drawing.Size(198, 20);
            this.textBoxPhoneNumber_EMP.TabIndex = 1;
            // 
            // buttonAdd_EMP
            // 
            this.buttonAdd_EMP.Location = new System.Drawing.Point(195, 184);
            this.buttonAdd_EMP.Name = "buttonAdd_EMP";
            this.buttonAdd_EMP.Size = new System.Drawing.Size(100, 35);
            this.buttonAdd_EMP.TabIndex = 2;
            this.buttonAdd_EMP.Text = "Добавить";
            this.buttonAdd_EMP.UseVisualStyleBackColor = true;
            this.buttonAdd_EMP.Click += new System.EventHandler(this.buttonAdd_EMP_Click_1);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(307, 231);
            this.Controls.Add(this.buttonAdd_EMP);
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
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber_EMP;
        private System.Windows.Forms.TextBox textBoxNumber_EMP;
        private System.Windows.Forms.Label labelName_EMP;
        private System.Windows.Forms.Label labelAddress_EMP;
        private System.Windows.Forms.Label labelPhoneNumber_EMP;
        private System.Windows.Forms.TextBox textBoxName_EMP;
        private System.Windows.Forms.TextBox textBoxAddress_EMP;
        private System.Windows.Forms.TextBox textBoxPhoneNumber_EMP;
        private System.Windows.Forms.Button buttonAdd_EMP;
    }
}