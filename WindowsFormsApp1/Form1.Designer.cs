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
            this.NCM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.mercosul;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ListaProdutos
            // 
            this.ListaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NCM,
            this.Modal,
            this.Qtd,
            this.Preço});
            this.ListaProdutos.FullRowSelect = true;
            this.ListaProdutos.Location = new System.Drawing.Point(441, 14);
            this.ListaProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaProdutos.Name = "ListaProdutos";
            this.ListaProdutos.Size = new System.Drawing.Size(390, 528);
            this.ListaProdutos.TabIndex = 1;
            this.ListaProdutos.UseCompatibleStateImageBehavior = false;
            this.ListaProdutos.View = System.Windows.Forms.View.Details;
            this.ListaProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListaProdutos_MouseDoubleClick);
            // 
            // NCM
            // 
            this.NCM.Text = "NCM";
            this.NCM.Width = 70;
            // 
            // Modal
            // 
            this.Modal.Text = "Modal";
            this.Modal.Width = 80;
            // 
            // Qtd
            // 
            this.Qtd.Text = "Qtd.";
            this.Qtd.Width = 50;
            // 
            // Preço
            // 
            this.Preço.Text = "Preço";
            this.Preço.Width = 80;
            // 
            // AddProduto
            // 
            this.AddProduto.Location = new System.Drawing.Point(848, 14);
            this.AddProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ClientSize = new System.Drawing.Size(961, 553);
            this.Controls.Add(this.AddProduto);
            this.Controls.Add(this.ListaProdutos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private ColumnHeader Modal;
        private ColumnHeader Preço;
        private ColumnHeader NCM;
        private ColumnHeader Qtd;
        private Button AddProduto;
    }
}

