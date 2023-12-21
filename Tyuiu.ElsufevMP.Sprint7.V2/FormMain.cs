using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.ElsufevMP.Sprint7.V2.Lib;

namespace Tyuiu.ElsufevMP.Sprint7.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_EMP.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_EMP.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        private void buttonInfo_EMP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_EMP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_EMP.ShowDialog();
            openFilePath = openFileDialogTask_EMP.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            arrayValues = ds.GetBase(openFilePath);
            buttonOpenBase_EMP.Enabled = true;
            buttonDelete_EMP.Enabled = true;
            buttonEdit_EMP.Enabled = true;
        }

        private void buttonOpenBase_EMP_Click(object sender, EventArgs e)
        {
            dataGridViewMain_EMP.ColumnCount = columns;
            dataGridViewMain_EMP.RowCount = rows;

            dataGridViewMain_EMP.Columns[0].HeaderText = "Порядковый номер";
            dataGridViewMain_EMP.Columns[1].HeaderText = "Название магазина";
            dataGridViewMain_EMP.Columns[2].HeaderText = "Адрес магазина";
            dataGridViewMain_EMP.Columns[3].HeaderText = "Телефон магазина";
            dataGridViewMain_EMP.Columns[0].Width = 80;
            dataGridViewMain_EMP.Columns[1].Width = 150;
            dataGridViewMain_EMP.Columns[2].Width = 150;
            dataGridViewMain_EMP.Columns[3].Width = 80;


            dataGridViewMain_EMP.Rows[0].ReadOnly = true;
            dataGridViewMain_EMP.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMain_EMP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(openFilePath);
            buttonDelete_EMP.Visible = true;
            buttonEdit_EMP.Visible = true;
            buttonAdd_EMP.Visible = true;
            buttonSearch_EMP.Visible = true;
            buttonSaveFile_EMP.Enabled = true;
        }

        private void buttonDelete_EMP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain_EMP.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewMain_EMP.CurrentRow.Index;
                    dataGridViewMain_EMP.Rows.Remove(dataGridViewMain_EMP.Rows[a]);
                    if (dataGridViewMain_EMP.Rows.Count == 1)
                    {
                        dataGridViewMain_EMP.Rows.Clear();
                    }
                }
                if (dataGridViewMain_EMP.Rows.Count <= 1)
                {
                    buttonDelete_EMP.Enabled = false;
                    buttonEdit_EMP.Enabled = false;
                }
                if (dataGridViewMain_EMP.Rows.Count > 1)
                {
                    buttonDelete_EMP.Enabled = true;
                }
                buttonOpenBase_EMP.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_EMP_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
            buttonOpenBase_EMP.Enabled = false;
        }

        private void buttonEdit_EMP_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewMain_EMP.CurrentRow.Index;
                FormEdit fed = new FormEdit(this);
                fed.textBoxNumber_EMP.Text = dataGridViewMain_EMP.Rows[a].Cells[0].Value.ToString();
                fed.textBoxName_EMP.Text = dataGridViewMain_EMP.Rows[a].Cells[1].Value.ToString();
                fed.textBoxAddress_EMP.Text = dataGridViewMain_EMP.Rows[a].Cells[2].Value.ToString();
                fed.textBoxPhoneNumber_EMP.Text = dataGridViewMain_EMP.Rows[a].Cells[3].Value.ToString();
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_EMP_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch(this);
            formSearch.ShowDialog();
        }

        private void buttonSaveFile_EMP_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_EMP.FileName = "StoreBase.csv";
            saveFileDialogTask_EMP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_EMP.ShowDialog();

            string path = saveFileDialogTask_EMP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMain_EMP.RowCount;
            int columns = dataGridViewMain_EMP.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMain_EMP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMain_EMP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void руководствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInstruction forminst = new FormInstruction();
            forminst.ShowDialog();
        }
    }
}
