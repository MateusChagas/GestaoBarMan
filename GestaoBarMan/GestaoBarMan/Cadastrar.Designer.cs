namespace GestaoBarMan
{
    partial class Cadastrar
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
            this.label5 = new System.Windows.Forms.Label();
            this.NomeFuncionarioCadastro = new System.Windows.Forms.TextBox();
            this.LoginCadastro = new System.Windows.Forms.TextBox();
            this.SenhaCadastro = new System.Windows.Forms.TextBox();
            this.SalvarCadastro = new System.Windows.Forms.Button();
            this.VoltarCadastro = new System.Windows.Forms.Button();
            this.CheckboxCadastrar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de usuários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuário Master:";
            // 
            // NomeFuncionarioCadastro
            // 
            this.NomeFuncionarioCadastro.Location = new System.Drawing.Point(215, 91);
            this.NomeFuncionarioCadastro.Name = "NomeFuncionarioCadastro";
            this.NomeFuncionarioCadastro.Size = new System.Drawing.Size(362, 20);
            this.NomeFuncionarioCadastro.TabIndex = 5;
            // 
            // LoginCadastro
            // 
            this.LoginCadastro.Location = new System.Drawing.Point(215, 144);
            this.LoginCadastro.Name = "LoginCadastro";
            this.LoginCadastro.Size = new System.Drawing.Size(362, 20);
            this.LoginCadastro.TabIndex = 6;
            // 
            // SenhaCadastro
            // 
            this.SenhaCadastro.Location = new System.Drawing.Point(215, 187);
            this.SenhaCadastro.Name = "SenhaCadastro";
            this.SenhaCadastro.PasswordChar = '*';
            this.SenhaCadastro.Size = new System.Drawing.Size(362, 20);
            this.SenhaCadastro.TabIndex = 7;
            // 
            // SalvarCadastro
            // 
            this.SalvarCadastro.Location = new System.Drawing.Point(288, 278);
            this.SalvarCadastro.Name = "SalvarCadastro";
            this.SalvarCadastro.Size = new System.Drawing.Size(75, 23);
            this.SalvarCadastro.TabIndex = 9;
            this.SalvarCadastro.Text = "Salvar";
            this.SalvarCadastro.UseVisualStyleBackColor = true;
            this.SalvarCadastro.Click += new System.EventHandler(this.SalvarCadastro_Click);
            // 
            // VoltarCadastro
            // 
            this.VoltarCadastro.Location = new System.Drawing.Point(399, 277);
            this.VoltarCadastro.Name = "VoltarCadastro";
            this.VoltarCadastro.Size = new System.Drawing.Size(75, 23);
            this.VoltarCadastro.TabIndex = 10;
            this.VoltarCadastro.Text = "Voltar";
            this.VoltarCadastro.UseVisualStyleBackColor = true;
            this.VoltarCadastro.Click += new System.EventHandler(this.VoltarCadastro_Click);
            // 
            // CheckboxCadastrar
            // 
            this.CheckboxCadastrar.AutoSize = true;
            this.CheckboxCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxCadastrar.Location = new System.Drawing.Point(167, 228);
            this.CheckboxCadastrar.Name = "CheckboxCadastrar";
            this.CheckboxCadastrar.Size = new System.Drawing.Size(276, 22);
            this.CheckboxCadastrar.TabIndex = 8;
            this.CheckboxCadastrar.Text = "Marcar se o usuário for administrador";
            this.CheckboxCadastrar.UseVisualStyleBackColor = true;
            this.CheckboxCadastrar.CheckedChanged += new System.EventHandler(this.CheckboxCadastrar_CheckedChanged);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 344);
            this.Controls.Add(this.VoltarCadastro);
            this.Controls.Add(this.SalvarCadastro);
            this.Controls.Add(this.CheckboxCadastrar);
            this.Controls.Add(this.SenhaCadastro);
            this.Controls.Add(this.LoginCadastro);
            this.Controls.Add(this.NomeFuncionarioCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomeFuncionarioCadastro;
        private System.Windows.Forms.TextBox LoginCadastro;
        private System.Windows.Forms.TextBox SenhaCadastro;
        private System.Windows.Forms.Button SalvarCadastro;
        private System.Windows.Forms.Button VoltarCadastro;
        private System.Windows.Forms.CheckBox CheckboxCadastrar;
    }
}