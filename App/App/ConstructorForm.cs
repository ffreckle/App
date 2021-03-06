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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet1.tkani". При необходимости она может быть перемещена или удалена.
            this.tkaniTableAdapter.Fill(this.shopDataSet1.tkani);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.furniture". При необходимости она может быть перемещена или удалена.
            this.furnitureTableAdapter.Fill(this.shopDataSet.furniture);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected_furniture = Convert.ToInt32(comboBox2.SelectedValue);
            int selected_tkani = Convert.ToInt32(comboBox1.SelectedValue);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO izdelie (Наименование, Длина, Ширина) " + "VALUES (@name,@width,@height); SELECT SCOPE_IDENTITY(); ", connection);
                command.Parameters.AddWithValue("@name", textBox1.Text);
                command.Parameters.AddWithValue("@width", textBox2.Text);
                command.Parameters.AddWithValue("@height", textBox3.Text);
                
                int izdelie = Convert.ToInt32(command.ExecuteScalar());

                SqlCommand command1 = new SqlCommand("INSERT INTO furniture_izdelie (furniture_id, izdelie_id, razmeshenie, width, height, turn, counter) VALUES (" + selected_furniture + ", " + izdelie + ",0,@width,@height,0,0);", connection);
                command1.Parameters.AddWithValue("@width", textBox2.Text);
                command1.Parameters.AddWithValue("@height", textBox3.Text);

                int furniture_izdelie = Convert.ToInt32(command1.ExecuteScalar());

                SqlCommand command2 = new SqlCommand("INSERT INTO tkani_izdelie (tkani_id, izdelie_id) VALUES (" + selected_tkani + ", " + izdelie + ");", connection);

                int tkani_izdelie = Convert.ToInt32(command2.ExecuteScalar());

                connection.Close();
                MessageBox.Show("Сохранено! \n");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
            catch
            {
                MessageBox.Show("Ошибка! \n");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Draw();
        }

        private void Draw()
        {
            if(textBox2.Text.Trim().Length == 0 || textBox3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите размеры изделия!");
            }
            else
            {
                Graphics g = panel1.CreateGraphics();
                g.Clear(Color.White);
                Pen p = new Pen(Color.Black, 1);
                int w = Convert.ToInt32(textBox2.Text.Trim());
                int h = Convert.ToInt32(textBox3.Text.Trim());
                g.DrawRectangle(p, 10, 10, w, h);

                DataRowView item = (DataRowView)comboBox1.SelectedItem;
                String color = item.Row.ItemArray[3].ToString();
                String ris = item.Row.ItemArray[4].ToString();
                Brush brush;

                if (ris.Contains("jpg"))
                {
                    Image img = Image.FromFile(ris);
                    Bitmap bimage = new Bitmap(img);
                    TextureBrush tb = new TextureBrush(bimage);
                    g.FillRectangle(tb, 11, 11, w - 1, h - 1);
                }
                else
                {
                    
                    switch (color)
                    {
                        case "красный":
                            brush = new SolidBrush(Color.Red);
                            g.FillRectangle(brush, 11, 11, w - 1, h - 1);
                            break;
                        case "зеленый":
                            brush = new SolidBrush(Color.FromArgb(255, 0, 255, 0));
                            g.FillRectangle(brush, 11, 11, w - 1, h - 1);
                            break;

                        default:
                            brush = new SolidBrush(Color.White);
                            g.FillRectangle(brush, 11, 11, w - 1, h - 1);
                            break;


                    }
                }

                
            }
        }

        private void ConstructorForm_Activated(object sender, EventArgs e)
        {
            this.tkaniTableAdapter.Fill(this.shopDataSet1.tkani);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddTkani addtkani = new AddTkani();
            addtkani.Show();
        }
        /*
fillCombos();
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
*/
    }
}
