﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App
{
    public partial class UserIzdelieForm : Form
    {
        

        public UserIzdelieForm()
        {
            InitializeComponent();
        }

        private void UserIzdelieForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet3Izdelie.izdelie". При необходимости она может быть перемещена или удалена.
            this.izdelieTableAdapter1.Fill(this.shopDataSet3Izdelie.izdelie);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
