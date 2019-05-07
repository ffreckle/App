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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void конструкторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cons = new ConstructorForm();
            cons.Show();
        }

        private void изделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserIzdelieForm userizdelie = new UserIzdelieForm();
            userizdelie.Show();
        }

        private void тканиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTkaniForm usertkani = new UserTkaniForm();
            usertkani.Show();
        }

        private void фурнитураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserFurnitureForm userfurniture = new UserFurnitureForm();
            userfurniture.Show();
        }
    }
}
