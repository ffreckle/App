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

    public partial class UserOrderForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.dbConnectionSettings);
        double total = 0;
        double izdelie_price = 0;
        
        public UserOrderForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataRowView item = (DataRowView)comboBox1.SelectedItem;
            //MessageBox.Show(item.Row.ItemArray[3].ToString());

            DataRowView item = (DataRowView)comboBox1.SelectedItem;
            double item_width = Convert.ToDouble(item.Row.ItemArray[3]);
            double item_height = Convert.ToDouble(item.Row.ItemArray[4]);

            MessageBox.Show(item_height + ", " + item_width);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT tkani.ID, tkani.ширина, tkani.длина, tkani.цена " +
                "FROM tkani_izdelie INNER JOIN tkani ON tkani_izdelie.tkani_id = tkani.ID " +
                "WHERE tkani_izdelie.izdelie_id=" + comboBox1.SelectedValue
                , connection);
            SqlDataReader reader = command.ExecuteReader();
            int id = 0;
            double width = 0;
            double height = 0;
            double price = 0;
            while (reader.Read())
            {
                id = Convert.ToInt32(reader[0] == DBNull.Value ? 0 : reader[0]);
                width = Convert.ToDouble(reader[1] == DBNull.Value ? 0 : reader[1]);
                height = Convert.ToDouble(reader[2] == DBNull.Value ? 0 : reader[2]);
                price = Convert.ToDouble(reader[3] == DBNull.Value ? 0 : reader[3]);
            }
            MessageBox.Show(price + "," + width + "," + height);
            izdelie_price = (item_width * item_height * price) / (width * height);
            total = izdelie_price * Convert.ToInt32(textBox1.Text);
            label6.Text = total.ToString();


            reader.Close();
            connection.Close();

        }

        private void UserOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet2.izdelie". При необходимости она может быть перемещена или удалена.
            this.izdelieTableAdapter.Fill(this.shopDataSet2.izdelie);

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int parsedValue = 0;
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }
            total = izdelie_price * parsedValue;
            label6.Text = total.ToString();
        }
    }
}
