using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem p1 = new ListViewItem("Carne Bovina", 0);
            p1.SubItems.Add("R$100,00");
            p1.SubItems.Add("Carne");

            ListViewItem p2 = new ListViewItem("Carne Suina", 0);
            p2.SubItems.Add("R$500,00");
            p2.SubItems.Add("Carne");

            ListViewItem p3 = new ListViewItem("Peixe", 0);
            p3.SubItems.Add("R$80,00");
            p3.SubItems.Add("Carne");

            ListaProdutos.Items.Add(p1);
            ListaProdutos.Items.Add(p2);
            ListaProdutos.Items.Add(p3);
        }
    }
}
