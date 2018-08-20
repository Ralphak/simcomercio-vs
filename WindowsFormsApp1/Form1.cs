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
                item.SubItems.Add(reader.GetDouble(28).ToString());
                item.SubItems.Add(reader.GetDouble(30).ToString());
                
                ListaProdutos.Items.Add(item);
            }
            conexaoDB.Close();
        }

        private void ListaProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmdDB.CommandText = "select * from Produtos where NCM=" + ListaProdutos.SelectedItems[0].Text;
            conexaoDB.Open();
            reader = cmdDB.ExecuteReader();
            reader.Read();
            string mensagem = "Detalhes do Produto:\n" +
                "\n" + reader.GetName(0) + ": " + reader.GetInt32(0).ToString() +
                "\n" + reader.GetName(1) + ": " + reader.GetString(1) ;
            for (int i = 2; i <= 34; i++)
            {
                mensagem += "\n" + reader.GetName(i) + ": " + reader.GetDouble(i).ToString();
            }
            MessageBox.Show(mensagem);
            conexaoDB.Close();
        }

        private void AddProduto_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
}
