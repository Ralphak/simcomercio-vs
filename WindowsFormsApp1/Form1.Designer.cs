using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListaProdutos = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qtd2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.mercosul;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ListaProdutos
            // 
            this.ListaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Produto,
            this.Tipo,
            this.Qtd,
            this.Preço});
            this.ListaProdutos.FullRowSelect = true;
            this.ListaProdutos.Location = new System.Drawing.Point(441, 13);
            this.ListaProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.ListaProdutos.Name = "ListaProdutos";
            this.ListaProdutos.Size = new System.Drawing.Size(420, 527);
            this.ListaProdutos.TabIndex = 1;
            this.ListaProdutos.UseCompatibleStateImageBehavior = false;
            this.ListaProdutos.View = System.Windows.Forms.View.Details;
            this.ListaProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListaProdutos_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 90;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            // 
            // Qtd
            // 
            this.Qtd.Text = "Qtd";
            this.Qtd.Width = 40;
            // 
            // Preço
            // 
            this.Preço.Text = "Preço";
            this.Preço.Width = 80;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID2,
            this.Produto2,
            this.Tipo2,
            this.Qtd2,
            this.Preço2});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(977, 13);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 527);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID2
            // 
            this.ID2.Text = "ID";
            this.ID2.Width = 40;
            // 
            // Produto2
            // 
            this.Produto2.Text = "Produto";
            this.Produto2.Width = 90;
            // 
            // Tipo2
            // 
            this.Tipo2.Text = "Tipo";
            // 
            // Qtd2
            // 
            this.Qtd2.Text = "Qtd";
            this.Qtd2.Width = 40;
            // 
            // Preço2
            // 
            this.Preço2.Text = "Preço";
            this.Preço2.Width = 80;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(870, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(870, 224);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(870, 487);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 7;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(870, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddProduto
            // 
            this.AddProduto.Location = new System.Drawing.Point(870, 30);
            this.AddProduto.Name = "AddProduto";
            this.AddProduto.Size = new System.Drawing.Size(100, 50);
            this.AddProduto.TabIndex = 9;
            this.AddProduto.Text = "Adicionar Produto";
            this.AddProduto.UseVisualStyleBackColor = true;
            this.AddProduto.Click += new System.EventHandler(this.AddProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 553);
            this.Controls.Add(this.AddProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ListaProdutos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Comércio Exterior no Mercosul";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private ListView ListaProdutos;
        private ColumnHeader Produto;
        private ColumnHeader Preço;
        private ColumnHeader Tipo;
        private ListView listView1;
        private ColumnHeader Produto2;
        private ColumnHeader Preço2;
        private ColumnHeader Tipo2;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button1;
        private ColumnHeader ID;
        private ColumnHeader Qtd;
        private ColumnHeader ID2;
        private ColumnHeader Qtd2;
        private Button AddProduto;
    }
}

