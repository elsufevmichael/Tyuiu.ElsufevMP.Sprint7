﻿using System;
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
    public partial class FormInstruction : Form
    {
        public FormInstruction()
        {
            InitializeComponent();
        }

        private void buttonOk_EMP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
