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
    public partial class frm11_Agenda : Form
    {
        public frm11_Agenda()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Agenda o_Agenda = new Agenda();

            o_Agenda.nome = txtNome.Text.ToString();
            o_Agenda.fone = txtTelefone.Text.ToString();

            o_Agenda.imprimirDados();
        }
    }
}
