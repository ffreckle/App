using System;
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
    public partial class ConstructorForm : Form
    {
        private class Tkani
        {
            public int id { get; set; }
            public string название { get; set; }
            public string цвет { get; set; }
            public double цена { get; set; }

            public Tkani (int i, string n, string c, double p)
            {
                this.id = i;
                this.название = n;
                this.цвет = c;
                this.цена = p;
            }
        }
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionSettings);

        public ConstructorForm()
        {
            InitializeComponent();
        }

        private void ConstructorForm_Load(object sender, EventArgs e)
        {
            fillCombos();
        }

        public void fillCombos()
        {
            String sql = "SELECT id, название, цвет, цена FROM tkani";
            connection.Open();
            SqlCommand command = new SqlCommand(sql,connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Tkani> listoftkani = new List<Tkani>();

            while (reader.Read())
            {
                listoftkani.Add(new Tkani(Convert.ToInt32(reader["id"]), reader["название"].ToString() + "," + reader["цвет"], reader["цвет"].ToString(),Convert.ToDouble(reader["цена"])));
            }
            comboBox1.DataSource = listoftkani;
            comboBox1.DisplayMember = "название";
            reader.Close();
        }

    }
}
