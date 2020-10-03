using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgOrientadaObjetosCSharp
{
    public partial class frm10_InterfaceCampos : Form
    {
        public frm10_InterfaceCampos()
        {
            InitializeComponent();
        }

        private void btnStrEntrada_Click(object sender, EventArgs e)
        {
            string nome;
            nome = txtStrEntrada.Text;

            if (nome.Trim() == "")
            {
                MessageBox.Show("Por favor informe o nome.",
                               "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStrEntrada.Focus();
            }
            

        }

        private void btnStrSaída_Click(object sender, EventArgs e)
        {
            String sobrenome;

            sobrenome = "Silva";

            txtStrSaida.Text = sobrenome;
            lblStrSaida.Text = sobrenome;
        }

        private void btnNroEntrada_Click(object sender, EventArgs e)
        {            
            decimal altura;

            altura = txtNroEntrada.Value;

        }

        private void btnNroSaída_Click(object sender, EventArgs e)
        {
            decimal altura;

            altura = 1.70m;

            txtNroSaida.Text = altura.ToString();
            lblNroSaida.Text = altura.ToString();
        }
    }
}
