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
    public partial class FormEdit : Form
    {
        FormMain fmain;
        public FormEdit(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonEdit_EMP_Click(object sender, EventArgs e)
        {
            int a = fmain.dataGridViewMain_EMP.CurrentRow.Index;
            fmain.dataGridViewMain_EMP.Rows[a].Cells[0].Value = textBoxNumber_EMP.Text;
            fmain.dataGridViewMain_EMP.Rows[a].Cells[1].Value = textBoxName_EMP.Text;
            fmain.dataGridViewMain_EMP.Rows[a].Cells[2].Value = textBoxAddress_EMP.Text;
            fmain.dataGridViewMain_EMP.Rows[a].Cells[3].Value = textBoxPhoneNumber_EMP.Text;
            this.Close();
        }
    }
}
