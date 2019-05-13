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
    public partial class AddTkani : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionSettings);
        String filename;
        public AddTkani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG images |*.jpg";
            openFileDialog1.InitialDirectory = "C:/App/App/Resourses";
            openFileDialog1.Title = "Выбрать картинку";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                MessageBox.Show(filename);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            try
            {

            
            Random random = new Random();
            String artikul = "User-" + random.Next(1000000);
            SqlCommand command = new SqlCommand("INSERT INTO tkani (Артикул,Название,Рисунок) VALUES ('" + artikul + "',@name,'" + filename + "');", connection);
            command.Parameters.AddWithValue("@name", textBox1.Text);
            command.ExecuteScalar();

            MessageBox.Show("Ткань добавлена!");
                this.Close();

            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении!");
            }
        }
    }
}
