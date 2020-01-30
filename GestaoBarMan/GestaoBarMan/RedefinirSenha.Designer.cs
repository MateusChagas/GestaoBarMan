namespace GestaoBarMan
{
    partial class RedefinirSenha
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
            this.LoginRedefinir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NovaSenha = new System.Windows.Forms.TextBox();
            this.Alterar = new System.Windows.Forms.Button();
            this.Rvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // LoginRedefinir
            // 
            this.LoginRedefinir.AllowDrop = true;
            this.LoginRedefinir.Enabled = false;
            this.LoginRedefinir.Location = new System.Drawing.Point(124, 58);
            this.LoginRedefinir.Name = "LoginRedefinir";
            this.LoginRedefinir.Size = new System.Drawing.Size(241, 20);
            this.LoginRedefinir.TabIndex = 1;
            this.LoginRedefinir.TextChanged += new System.EventHandler(this.senharedefinir_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova Senha";
            // 
            // NovaSenha
            // 
            this.NovaSenha.AllowDrop = true;
            this.NovaSenha.Location = new System.Drawing.Point(124, 113);
            this.NovaSenha.Name = "NovaSenha";
            this.NovaSenha.PasswordChar = '*';
            this.NovaSenha.Size = new System.Drawing.Size(241, 20);
            this.NovaSenha.TabIndex = 3;
            // 
            // Alterar
            // 
            this.Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alterar.Location = new System.Drawing.Point(185, 166);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 30);
            this.Alterar.TabIndex = 4;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Rvoltar
            // 
            this.Rvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rvoltar.Location = new System.Drawing.Point(290, 166);
            this.Rvoltar.Name = "Rvoltar";
            this.Rvoltar.Size = new System.Drawing.Size(75, 30);
            this.Rvoltar.TabIndex = 5;
            this.Rvoltar.Text = "Voltar";
            this.Rvoltar.UseVisualStyleBackColor = true;
            this.Rvoltar.Click += new System.EventHandler(this.Rvoltar_Click);
            // 
            // RedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.Rvoltar);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.NovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginRedefinir);
            this.Controls.Add(this.label1);
            this.Name = "RedefinirSenha";
            this.Text = "RedefinirSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginRedefinir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NovaSenha;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Rvoltar;
    }
}