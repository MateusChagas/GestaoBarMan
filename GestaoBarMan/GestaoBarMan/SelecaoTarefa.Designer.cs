namespace GestaoBarMan
{
    partial class SelecaoTarefa
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
            this.CadastrarProduto = new System.Windows.Forms.Button();
            this.IniciarVenda = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a tarefa";
            // 
            // CadastrarProduto
            // 
            this.CadastrarProduto.Location = new System.Drawing.Point(92, 134);
            this.CadastrarProduto.Name = "CadastrarProduto";
            this.CadastrarProduto.Size = new System.Drawing.Size(113, 41);
            this.CadastrarProduto.TabIndex = 1;
            this.CadastrarProduto.Text = "Cadastrar Produto";
            this.CadastrarProduto.UseVisualStyleBackColor = true;
            this.CadastrarProduto.Click += new System.EventHandler(this.CadastrarProduto_Click);
            // 
            // IniciarVenda
            // 
            this.IniciarVenda.Location = new System.Drawing.Point(270, 134);
            this.IniciarVenda.Name = "IniciarVenda";
            this.IniciarVenda.Size = new System.Drawing.Size(109, 41);
            this.IniciarVenda.TabIndex = 2;
            this.IniciarVenda.Text = "Iniciar Vendas";
            this.IniciarVenda.UseVisualStyleBackColor = true;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(402, 219);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 3;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // SelecaoTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 280);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.IniciarVenda);
            this.Controls.Add(this.CadastrarProduto);
            this.Controls.Add(this.label1);
            this.Name = "SelecaoTarefa";
            this.Text = "SelecaoTarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CadastrarProduto;
        private System.Windows.Forms.Button IniciarVenda;
        private System.Windows.Forms.Button Voltar;
    }
}