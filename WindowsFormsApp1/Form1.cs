using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static SqlConnection conexaoDB = new SqlConnection(ConfigurationManager.ConnectionStrings["registro_produtosConnectionString"].ConnectionString);
        SqlCommand cmdDB = new SqlCommand("select * from Produtos", conexaoDB);
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexaoDB.Open();
            reader = cmdDB.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetInt32(0).ToString());
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetInt32(4).ToString());
                item.SubItems.Add("R$" + reader.GetSqlMoney(5));
                ListaProdutos.Items.Add(item);
            }
            conexaoDB.Close();
        }

        private void ListaProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmdDB.CommandText = "select * from Produtos where Id=" + ListaProdutos.SelectedItems[0].Text;
            conexaoDB.Open();
            reader = cmdDB.ExecuteReader();
            reader.Read();
            MessageBox.Show("Detalhes do Produto:\n" +
                "\n" + reader.GetName(1) + ": " + reader.GetString(1) +
                "\n" + reader.GetName(2) + ": " + reader.GetString(2) +
                "\n" + reader.GetName(3) + ": " + reader.GetString(3) +
                "\n" + reader.GetName(4) + ": " + reader.GetInt32(4) +
                "\n" + reader.GetName(5) + ": R$" + reader.GetSqlMoney(5) +
                "\n" + reader.GetName(6) + ": " + reader.GetInt16(6) +
                "\nDimensões: " + reader.GetByte(7) + "m X " + reader.GetByte(8) + "m X " + reader.GetByte(9) +
                "m\n" + reader.GetName(10) + ": " + reader.GetDecimal(10) +
                "%\nClassificação Fiscal ou NCM: " + reader.GetInt32(11));
            conexaoDB.Close();
        }

        private void AddProduto_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
}
