using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        static SqlConnection conexaoDB = new SqlConnection(ConfigurationManager.ConnectionStrings["registro_produtosConnectionString"].ConnectionString);
        SqlCommand cmdDB = new SqlCommand("insert into Produtos (Nome, Tipo, Especificacao, Quantidade, Preco, Peso, Comprimento, Largura, Altura, TaxaCambio, NCM)", conexaoDB);
        SqlDataReader reader;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            conexaoDB.Open();
            cmdDB.CommandText += " values (" +
                Nome.Text + ", " +
                Tipo.Text + ", " +
                Especificacao.Text + ", " +
                Qtd.Value + ", " +
                Preco.Value + ", " +
                Peso.Value + ", " +
                Comprimento.Value + ", " +
                Largura.Value + ", " +
                Altura.Value + ", " +
                TaxaCambio.Value + ", " +
                NCM.Value + ")";
            int linhas = cmdDB.ExecuteNonQuery();
            conexaoDB.Close();
            Application.Restart();
        }
    }
}
