using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validcomp
{
    public partial class acceuil : Form
    {
        public acceuil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nouvel_etud nouvel_etud = new nouvel_etud();
            nouvel_etud.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
