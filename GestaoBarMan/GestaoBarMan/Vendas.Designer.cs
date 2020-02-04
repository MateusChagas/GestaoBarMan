namespace GestaoBarMan
{
    partial class Vendas
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
            this.Produtos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ValorVendaItem = new System.Windows.Forms.Label();
            this.ValorItemVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QtdItemVenda = new System.Windows.Forms.TextBox();
            this.TotalVendaItem = new System.Windows.Forms.Label();
            this.TotalVenda = new System.Windows.Forms.TextBox();
            this.FinalizarCompra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Produtos
            // 
            this.Produtos.FormattingEnabled = true;
            this.Produtos.Location = new System.Drawing.Point(117, 48);
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(293, 21);
            this.Produtos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produtos";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(450, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(354, 397);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ValorVendaItem
            // 
            this.ValorVendaItem.AutoSize = true;
            this.ValorVendaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorVendaItem.Location = new System.Drawing.Point(12, 104);
            this.ValorVendaItem.Name = "ValorVendaItem";
            this.ValorVendaItem.Size = new System.Drawing.Size(119, 20);
            this.ValorVendaItem.TabIndex = 3;
            this.ValorVendaItem.Text = "Valor Unitário";
            // 
            // ValorItemVenda
            // 
            this.ValorItemVenda.Location = new System.Drawing.Point(137, 104);
            this.ValorItemVenda.Name = "ValorItemVenda";
            this.ValorItemVenda.Size = new System.Drawing.Size(100, 20);
            this.ValorItemVenda.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // QtdItemVenda
            // 
            this.QtdItemVenda.Location = new System.Drawing.Point(137, 168);
            this.QtdItemVenda.Name = "QtdItemVenda";
            this.QtdItemVenda.Size = new System.Drawing.Size(100, 20);
            this.QtdItemVenda.TabIndex = 6;
            // 
            // TotalVendaItem
            // 
            this.TotalVendaItem.AutoSize = true;
            this.TotalVendaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVendaItem.Location = new System.Drawing.Point(12, 235);
            this.TotalVendaItem.Name = "TotalVendaItem";
            this.TotalVendaItem.Size = new System.Drawing.Size(49, 20);
            this.TotalVendaItem.TabIndex = 7;
            this.TotalVendaItem.Text = "Total";
            // 
            // TotalVenda
            // 
            this.TotalVenda.Location = new System.Drawing.Point(137, 235);
            this.TotalVenda.Name = "TotalVenda";
            this.TotalVenda.Size = new System.Drawing.Size(100, 20);
            this.TotalVenda.TabIndex = 8;
            // 
            // FinalizarCompra
            // 
            this.FinalizarCompra.Location = new System.Drawing.Point(56, 375);
            this.FinalizarCompra.Name = "FinalizarCompra";
            this.FinalizarCompra.Size = new System.Drawing.Size(102, 51);
            this.FinalizarCompra.TabIndex = 9;
            this.FinalizarCompra.Text = "Finalizar Compra";
            this.FinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar Compra";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FinalizarCompra);
            this.Controls.Add(this.TotalVenda);
            this.Controls.Add(this.TotalVendaItem);
            this.Controls.Add(this.QtdItemVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValorItemVenda);
            this.Controls.Add(this.ValorVendaItem);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Produtos);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label ValorVendaItem;
        private System.Windows.Forms.TextBox ValorItemVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QtdItemVenda;
        private System.Windows.Forms.Label TotalVendaItem;
        private System.Windows.Forms.TextBox TotalVenda;
        private System.Windows.Forms.Button FinalizarCompra;
        private System.Windows.Forms.Button button1;
    }
}