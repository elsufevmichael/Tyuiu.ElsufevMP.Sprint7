
namespace Tyuiu.ElsufevMP.Sprint7.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_EMP = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_EMP = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_EMP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_EMP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_EMP
            // 
            this.buttonOK_EMP.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOK_EMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK_EMP.Location = new System.Drawing.Point(674, 383);
            this.buttonOK_EMP.Name = "buttonOK_EMP";
            this.buttonOK_EMP.Size = new System.Drawing.Size(114, 55);
            this.buttonOK_EMP.TabIndex = 0;
            this.buttonOK_EMP.Text = "OK";
            this.buttonOK_EMP.UseVisualStyleBackColor = false;
            this.buttonOK_EMP.Click += new System.EventHandler(this.buttonOK_EMP_Click);
            // 
            // pictureBoxAvatar_EMP
            // 
            this.pictureBoxAvatar_EMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAvatar_EMP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_EMP.Image")));
            this.pictureBoxAvatar_EMP.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_EMP.Name = "pictureBoxAvatar_EMP";
            this.pictureBoxAvatar_EMP.Size = new System.Drawing.Size(429, 426);
            this.pictureBoxAvatar_EMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_EMP.TabIndex = 1;
            this.pictureBoxAvatar_EMP.TabStop = false;
            // 
            // textBoxAbout_EMP
            // 
            this.textBoxAbout_EMP.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAbout_EMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_EMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAbout_EMP.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxAbout_EMP.Location = new System.Drawing.Point(448, 12);
            this.textBoxAbout_EMP.Multiline = true;
            this.textBoxAbout_EMP.Name = "textBoxAbout_EMP";
            this.textBoxAbout_EMP.Size = new System.Drawing.Size(340, 365);
            this.textBoxAbout_EMP.TabIndex = 2;
            this.textBoxAbout_EMP.Text = resources.GetString("textBoxAbout_EMP.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAbout_EMP);
            this.Controls.Add(this.pictureBoxAvatar_EMP);
            this.Controls.Add(this.buttonOK_EMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_EMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_EMP;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_EMP;
        private System.Windows.Forms.TextBox textBoxAbout_EMP;
    }
}