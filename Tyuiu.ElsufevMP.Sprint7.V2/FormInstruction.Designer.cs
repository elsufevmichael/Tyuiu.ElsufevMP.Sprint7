
namespace Tyuiu.ElsufevMP.Sprint7.V2
{
    partial class FormInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruction));
            this.buttonOk_EMP = new System.Windows.Forms.Button();
            this.textBoxAbout_EMP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk_EMP
            // 
            this.buttonOk_EMP.Location = new System.Drawing.Point(713, 377);
            this.buttonOk_EMP.Name = "buttonOk_EMP";
            this.buttonOk_EMP.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_EMP.TabIndex = 0;
            this.buttonOk_EMP.Text = "OK";
            this.buttonOk_EMP.UseVisualStyleBackColor = true;
            this.buttonOk_EMP.Click += new System.EventHandler(this.buttonOk_EMP_Click);
            // 
            // textBoxAbout_EMP
            // 
            this.textBoxAbout_EMP.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAbout_EMP.Location = new System.Drawing.Point(13, 13);
            this.textBoxAbout_EMP.Multiline = true;
            this.textBoxAbout_EMP.Name = "textBoxAbout_EMP";
            this.textBoxAbout_EMP.ReadOnly = true;
            this.textBoxAbout_EMP.Size = new System.Drawing.Size(775, 25);
            this.textBoxAbout_EMP.TabIndex = 1;
            this.textBoxAbout_EMP.Text = "Данная программа создана для владельцев сетей магазинов. Программа позволяет рабо" +
    "тать с базами данных в формате файла CSV";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(13, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(775, 90);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(13, 140);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(775, 231);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // FormInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxAbout_EMP);
            this.Controls.Add(this.buttonOk_EMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInstruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_EMP;
        private System.Windows.Forms.TextBox textBoxAbout_EMP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}