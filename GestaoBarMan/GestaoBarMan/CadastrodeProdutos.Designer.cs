namespace GestaoBarMan
{
    partial class CadastrodeProdutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeProduto = new System.Windows.Forms.TextBox();
            this.ValorProduto = new System.Windows.Forms.TextBox();
            this.QtdEstoque = new System.Windows.Forms.TextBox();
            this.CadastarProduto = new System.Windows.Forms.Button();
            this.VoltarCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade em estoque";
            // 
            // NomeProduto
            // 
            this.NomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NomeProduto.Location = new System.Drawing.Point(235, 119);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Size = new System.Drawing.Size(493, 20);
            this.NomeProduto.TabIndex = 4;
            // 
            // ValorProduto
            // 
            this.ValorProduto.Location = new System.Drawing.Point(235, 179);
            this.ValorProduto.Name = "ValorProduto";
            this.ValorProduto.Size = new System.Drawing.Size(54, 20);
            this.ValorProduto.TabIndex = 5;
            // 
            // QtdEstoque
            // 
            this.QtdEstoque.Location = new System.Drawing.Point(259, 239);
            this.QtdEstoque.Name = "QtdEstoque";
            this.QtdEstoque.Size = new System.Drawing.Size(56, 20);
            this.QtdEstoque.TabIndex = 6;
            // 
            // CadastarProduto
            // 
            this.CadastarProduto.Location = new System.Drawing.Point(317, 306);
            this.CadastarProduto.Name = "CadastarProduto";
            this.CadastarProduto.Size = new System.Drawing.Size(103, 31);
            this.CadastarProduto.TabIndex = 7;
            this.CadastarProduto.Text = "Cadastrar Produto";
            this.CadastarProduto.UseVisualStyleBackColor = true;
            this.CadastarProduto.Click += new System.EventHandler(this.CadastarProduto_Click);
            // 
            // VoltarCadastro
            // 
            this.VoltarCadastro.Location = new System.Drawing.Point(489, 306);
            this.VoltarCadastro.Name = "VoltarCadastro";
            this.VoltarCadastro.Size = new System.Drawing.Size(103, 31);
            this.VoltarCadastro.TabIndex = 8;
            this.VoltarCadastro.Text = "Voltar Cadastro";
            this.VoltarCadastro.UseVisualStyleBackColor = true;
            this.VoltarCadastro.Click += new System.EventHandler(this.VoltarCadastro_Click);
            // 
            // CadastrodeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 423);
            this.Controls.Add(this.VoltarCadastro);
            this.Controls.Add(this.CadastarProduto);
            this.Controls.Add(this.QtdEstoque);
            this.Controls.Add(this.ValorProduto);
            this.Controls.Add(this.NomeProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrodeProdutos";
            this.Text = "CadastrodeProdutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomeProduto;
        private System.Windows.Forms.TextBox ValorProduto;
        private System.Windows.Forms.TextBox QtdEstoque;
        private System.Windows.Forms.Button CadastarProduto;
        private System.Windows.Forms.Button VoltarCadastro;
    }
}