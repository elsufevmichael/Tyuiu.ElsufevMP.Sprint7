using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ElsufevMP.Sprint7.V2
{
    public partial class FormAdd : Form
    {
        FormMain fmain;
        public FormAdd(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonAdd_EMP_Click_1(object sender, EventArgs e)
        {
            fmain.dataGridViewMain_EMP.Rows.Add(textBoxNumber_EMP.Text, textBoxName_EMP.Text, textBoxAddress_EMP.Text, textBoxPhoneNumber_EMP.Text);
            fmain.buttonDelete_EMP.Enabled = true;
            this.Close();
        }
    }
}

