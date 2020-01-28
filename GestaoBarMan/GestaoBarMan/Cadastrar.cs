using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBarMan
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void VoltarCadastro_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();            
            this.Close();
            
        }
    }
}
