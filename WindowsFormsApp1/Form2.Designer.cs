using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.Tipo = new System.Windows.Forms.ComboBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelEspec = new System.Windows.Forms.Label();
            this.Qtd = new System.Windows.Forms.NumericUpDown();
            this.labelQtd = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.Preco = new System.Windows.Forms.NumericUpDown();
            this.labelPeso = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.NumericUpDown();
            this.labelDimensoes = new System.Windows.Forms.Label();
            this.Comprimento = new System.Windows.Forms.NumericUpDown();
            this.labelCambio = new System.Windows.Forms.Label();
            this.TaxaCambio = new System.Windows.Forms.NumericUpDown();
            this.Largura = new System.Windows.Forms.NumericUpDown();
            this.Altura = new System.Windows.Forms.NumericUpDown();
            this.labelNCM = new System.Windows.Forms.Label();
            this.NCM = new System.Windows.Forms.NumericUpDown();
            this.Especificacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Qtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comprimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxaCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Largura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCM)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(13, 16);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 17);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(116, 13);
            this.Nome.Margin = new System.Windows.Forms.Padding(4);
            this.Nome.MaxLength = 50;
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(132, 22);
            this.Nome.TabIndex = 1;
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(160, 280);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(80, 28);
            this.Enviar.TabIndex = 32;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Tipo
            // 
            this.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo.FormattingEnabled = true;
            this.Tipo.Items.AddRange(new object[] {
            "Carne",
            "Carro",
            "Limpeza",
            "Vegetal"});
            this.Tipo.Location = new System.Drawing.Point(116, 42);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(132, 24);
            this.Tipo.TabIndex = 34;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(13, 45);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(36, 17);
            this.labelTipo.TabIndex = 35;
            this.labelTipo.Text = "Tipo";
            this.labelTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEspec
            // 
            this.labelEspec.AutoSize = true;
            this.labelEspec.Location = new System.Drawing.Point(13, 76);
            this.labelEspec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEspec.Name = "labelEspec";
            this.labelEspec.Size = new System.Drawing.Size(95, 17);
            this.labelEspec.TabIndex = 36;
            this.labelEspec.Text = "Especificação";
            this.labelEspec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Qtd
            // 
            this.Qtd.Location = new System.Drawing.Point(116, 102);
            this.Qtd.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Qtd.Name = "Qtd";
            this.Qtd.Size = new System.Drawing.Size(132, 22);
            this.Qtd.TabIndex = 39;
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Location = new System.Drawing.Point(13, 104);
            this.labelQtd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(82, 17);
            this.labelQtd.TabIndex = 40;
            this.labelQtd.Text = "Quantidade";
            this.labelQtd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(13, 132);
            this.labelPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(77, 17);
            this.labelPreco.TabIndex = 42;
            this.labelPreco.Text = "Preço (R$)";
            this.labelPreco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Preco
            // 
            this.Preco.DecimalPlaces = 2;
            this.Preco.Location = new System.Drawing.Point(116, 130);
            this.Preco.Maximum = new decimal(new int[] {
            2061584302,
            21474836,
            0,
            131072});
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(132, 22);
            this.Preco.TabIndex = 41;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(13, 160);
            this.labelPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(71, 17);
            this.labelPeso.TabIndex = 44;
            this.labelPeso.Text = "Peso (Kg)";
            this.labelPeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Peso
            // 
            this.Peso.Location = new System.Drawing.Point(116, 158);
            this.Peso.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(132, 22);
            this.Peso.TabIndex = 43;
            // 
            // labelDimensoes
            // 
            this.labelDimensoes.AutoSize = true;
            this.labelDimensoes.Location = new System.Drawing.Point(13, 188);
            this.labelDimensoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDimensoes.Name = "labelDimensoes";
            this.labelDimensoes.Size = new System.Drawing.Size(157, 17);
            this.labelDimensoes.TabIndex = 46;
            this.labelDimensoes.Text = "Dimensões (C x L x A)m";
            this.labelDimensoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Comprimento
            // 
            this.Comprimento.Location = new System.Drawing.Point(177, 186);
            this.Comprimento.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Comprimento.Name = "Comprimento";
            this.Comprimento.Size = new System.Drawing.Size(60, 22);
            this.Comprimento.TabIndex = 45;
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Location = new System.Drawing.Point(13, 216);
            this.labelCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(136, 17);
            this.labelCambio.TabIndex = 48;
            this.labelCambio.Text = "Taxa de Câmbio (%)";
            this.labelCambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaxaCambio
            // 
            this.TaxaCambio.DecimalPlaces = 2;
            this.TaxaCambio.Location = new System.Drawing.Point(156, 214);
            this.TaxaCambio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.TaxaCambio.Name = "TaxaCambio";
            this.TaxaCambio.Size = new System.Drawing.Size(80, 22);
            this.TaxaCambio.TabIndex = 47;
            // 
            // Largura
            // 
            this.Largura.Location = new System.Drawing.Point(243, 186);
            this.Largura.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Largura.Name = "Largura";
            this.Largura.Size = new System.Drawing.Size(60, 22);
            this.Largura.TabIndex = 49;
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(309, 186);
            this.Altura.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(60, 22);
            this.Altura.TabIndex = 50;
            // 
            // labelNCM
            // 
            this.labelNCM.AutoSize = true;
            this.labelNCM.Location = new System.Drawing.Point(13, 244);
            this.labelNCM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNCM.Name = "labelNCM";
            this.labelNCM.Size = new System.Drawing.Size(184, 17);
            this.labelNCM.TabIndex = 52;
            this.labelNCM.Text = "Classificação Fiscal ou NCM";
            this.labelNCM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NCM
            // 
            this.NCM.Location = new System.Drawing.Point(204, 242);
            this.NCM.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NCM.Name = "NCM";
            this.NCM.Size = new System.Drawing.Size(132, 22);
            this.NCM.TabIndex = 51;
            // 
            // Especificacao
            // 
            this.Especificacao.Location = new System.Drawing.Point(116, 73);
            this.Especificacao.Margin = new System.Windows.Forms.Padding(4);
            this.Especificacao.MaxLength = 255;
            this.Especificacao.Name = "Especificacao";
            this.Especificacao.Size = new System.Drawing.Size(253, 22);
            this.Especificacao.TabIndex = 53;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 325);
            this.Controls.Add(this.Especificacao);
            this.Controls.Add(this.labelNCM);
            this.Controls.Add(this.NCM);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Largura);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.TaxaCambio);
            this.Controls.Add(this.labelDimensoes);
            this.Controls.Add(this.Comprimento);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.Qtd);
            this.Controls.Add(this.labelEspec);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.labelNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Produto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comprimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxaCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Largura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox Nome;
        private Button Enviar;
        private ComboBox Tipo;
        private Label labelTipo;
        private Label labelEspec;
        private NumericUpDown Qtd;
        private Label labelQtd;
        private Label labelPreco;
        private NumericUpDown Preco;
        private Label labelPeso;
        private NumericUpDown Peso;
        private Label labelDimensoes;
        private NumericUpDown Comprimento;
        private Label labelCambio;
        private NumericUpDown TaxaCambio;
        private NumericUpDown Largura;
        private NumericUpDown Altura;
        private Label labelNCM;
        private NumericUpDown NCM;
        private TextBox Especificacao;
    }
}