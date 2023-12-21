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
    public partial class FormSearch : Form
    {
        FormMain fmain;
        public FormSearch(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonFind_EMP_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < fmain.dataGridViewMain_EMP.RowCount; i++)
                {
                    fmain.dataGridViewMain_EMP.Rows[i].Selected = false;
                    for (int j = comboBoxSearchFilter_EMP.SelectedIndex; j < fmain.dataGridViewMain_EMP.ColumnCount; j++)
                        if (fmain.dataGridViewMain_EMP.Rows[i].Cells[j].Value != null)
                            if (fmain.dataGridViewMain_EMP.Rows[i].Cells[j].Value.ToString().Contains(textBoxFind_EMP.Text))
                            {
                                fmain.dataGridViewMain_EMP.Rows[i].Selected = true;
                                break;
                            }
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка при поиске", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
