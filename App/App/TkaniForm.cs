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
    public partial class TkaniForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionSettings);
        SqlDataAdapter sda;
        DataSet ds;


        public TkaniForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void LoadList()
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

        private void TkaniForm_Load(object sender, EventArgs e)
        {
            this.LoadList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ware = new WareForm();
            ware.Show();
            this.Close();
        }

       private void toolStripButton1_Click(object sender, EventArgs e)
       {
            try
            {
                DataSet changes = ds.GetChanges();
                if (changes != null)
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    builder.GetInsertCommand();
                    int updateRows = sda.Update(changes, "tkani");
                    ds.AcceptChanges();
                    MessageBox.Show("Данные обновлены...");

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уверены что хотите удалить запись?","Заголовок", MessageBoxButtons.OKCancel);
            
            try
            {
                foreach(DataGridViewRow items in dataGridView1.SelectedRows)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet changes = ds.GetChanges();
                if (changes != null)
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    builder.GetInsertCommand();
                    int updateRows = sda.Update(changes, "tkani");
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
    }
}
