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
    public partial class UserTkaniForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionSettings);
        SqlDataAdapter sda;
        DataSet ds; 

        public UserTkaniForm()
        {
            InitializeComponent();
        }

        private void UserTkaniForm_Load(object sender, EventArgs e)
        {
            {
                String query = "SELECT * FROM tkani";
                sda = new SqlDataAdapter(query, connection);
                ds = new DataSet();
                sda.Fill(ds, "tkani");
                dataGridView1.DataSource = ds.Tables["tkani"];

                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img.Name = "img";
                img.HeaderText = "Картинка";
                dataGridView1.Columns.Add(img);

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                    {
                        String basePath = "C:/App/App/Resourses/Tkani/";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
