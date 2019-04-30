using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class WareForm : Form
    {
        public WareForm()
        {
            InitializeComponent();
        }

        private void тканиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TkaniForm tkani = new TkaniForm();
            tkani.Show();
            this.Close();
        }

        private void фурнитураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form furniture = new FurnitureForm();
            furniture.Show();
            this.Close();
        }
    }
}
