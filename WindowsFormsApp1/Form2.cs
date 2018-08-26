using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        static SqlConnection conexaoDB = new SqlConnection(ConfigurationManager.ConnectionStrings["registro_produtosConnectionString"].ConnectionString);
        SqlCommand cmdSelect = new SqlCommand("select * from Produtos", conexaoDB),
            cmdInsert = new SqlCommand("insert into Produtos values(", conexaoDB);
        SqlDataReader reader;
        NumericUpDown[] listaInputs;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conexaoDB.Open();
            reader = cmdSelect.ExecuteReader();
            listaInputs = new NumericUpDown[reader.FieldCount];

            for (int i = 0; i < reader.FieldCount; i++)
            {
                //Geração dos campos no formulário
                Label label = new Label
                {
                    Text = reader.GetName(i),
                    Location = new Point(10, 21 * i)
                };
                NumericUpDown input = new NumericUpDown
                {
                    Text = "",
                    Maximum = decimal.MaxValue,
                    Location = new Point(110, 21 * i)
                };
                if (i > 1)
                {
                    //adiciona casas decimais nos campos não-inteiros
                    input.DecimalPlaces = 2;
                }
                this.Controls.Add(label);
                this.Controls.Add(input);
                listaInputs[i] = input;

                //Criação dos parâmetros de inserção
                cmdInsert.CommandText += "@" + reader.GetName(i) + ", ";
            }

            //apaga a última vírgula e fecha o comando
            cmdInsert.CommandText = cmdInsert.CommandText.Remove(cmdInsert.CommandText.Length - 2) + ")";

            //ajustar janela
            Enviar.Top = 21 * reader.FieldCount;
            this.Height = 21 * (reader.FieldCount + 3);
            this.CenterToScreen();

            conexaoDB.Close();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            conexaoDB.Open();
            reader = cmdSelect.ExecuteReader();

            //Tratamento do valor do modal de transporte
            string valorModal = "";
            switch (listaInputs[1].Value)
            {
                case 1:
                    valorModal = "Rodoviário";
                    break;
                case 2:
                    valorModal = "Marítimo";
                    break;
                case 3:
                    valorModal = "Aéreo";
                    break;
                default:
                    MessageBox.Show("Modal de transporte inválido!");
                    conexaoDB.Close();
                    return;
            }
            cmdInsert.Parameters.AddWithValue("@" + reader.GetName(1), valorModal);

            //Atribuição dos demais valores aos parâmetros
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (i == 1) continue; //Pula o modal de transporte
                cmdInsert.Parameters.AddWithValue("@" + reader.GetName(i), listaInputs[i].Value);
            }
            
            reader.Close();
            int linhas = cmdInsert.ExecuteNonQuery();
            conexaoDB.Close();
            Application.Restart();
        }
    }
}
