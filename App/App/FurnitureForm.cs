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
using System.IO;

namespace App
{
    public partial class FurnitureForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionSettings);

        SqlDataAdapter sda;
        DataSet ds;

        public FurnitureForm()
        {
            InitializeComponent();
        }

        public void LoadList()
        {
            String query = "SELECT * FROM furniture";
            sda = new SqlDataAdapter(query, connection);
            ds = new DataSet();
            sda.Fill(ds, "furniture");
            dataGridView1.DataSource = ds.Tables["furniture"];

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "img";
            img.HeaderText = "Картинка";
            dataGridView1.Columns.Add(img);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    String basePath = "C:/App/App/Resourses/Furniture/";
                    String filename = dataGridView1.Rows[i].Cells[1].Value.ToString() + ".jpg";
                    String fullPath = basePath + filename;

                    Image image;
                    if (File.Exists(fullPath))
                    {
                        image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        image = Image.FromFile(basePath + "null.jpg");
                    }
                    dataGridView1.Rows[i].Cells["img"].Value = image;


                }
            }
        }
    

        private void FurnitureForm_Load(object sender, EventArgs e)
        {
            this.LoadList();
        }
           

        private void button1_Click(object sender, EventArgs e)
        {
            Form ware = new WareForm();
            ware.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet changes = ds.GetChanges();
                if (changes != null)
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    builder.GetInsertCommand();
                    int updateRows = sda.Update(changes, "furniture");
                    ds.AcceptChanges();
                    MessageBox.Show("Данные обновлены...");
                    this.LoadList();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены что хотите удалить запись?", "Заголовок", MessageBoxButtons.OKCancel);

            try
            {
                foreach (DataGridViewRow items in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(items.Index);

                }

                this.button2_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
