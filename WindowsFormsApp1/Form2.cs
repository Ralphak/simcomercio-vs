using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        static SqlConnection conexaoDB = new SqlConnection(ConfigurationManager.ConnectionStrings["registro_produtosConnectionString"].ConnectionString);
        SqlCommand cmdDB = new SqlCommand("insert into Produtos(Nome, Tipo, Especificacao, Quantidade, Preco, Peso, Comprimento, Largura, Altura, TaxaCambio, NCM)" +
            "values(@Nome, @Tipo, @Especificacao, @Quantidade, @Preco, @Peso, @Comprimento, @Largura, @Altura, @TaxaCambio, @NCM)", conexaoDB);
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
            cmdDB.Parameters.AddWithValue("@Nome", Nome.Text);
            cmdDB.Parameters.AddWithValue("@Tipo", Tipo.Text);
            cmdDB.Parameters.AddWithValue("@Especificacao", Especificacao.Text);
            cmdDB.Parameters.AddWithValue("@Quantidade", Qtd.Value);
            cmdDB.Parameters.AddWithValue("@Preco", Preco.Value);
            cmdDB.Parameters.AddWithValue("@Peso", Peso.Value);
            cmdDB.Parameters.AddWithValue("@Comprimento", Comprimento.Value);
            cmdDB.Parameters.AddWithValue("@Largura", Largura.Value);
            cmdDB.Parameters.AddWithValue("@Altura", Altura.Value);
            cmdDB.Parameters.AddWithValue("@TaxaCambio", TaxaCambio.Value);
            cmdDB.Parameters.AddWithValue("@NCM", NCM.Value);
            int linhas = cmdDB.ExecuteNonQuery();
            conexaoDB.Close();
            Application.Restart();
        }
    }
}
