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
    public partial class frm06_AssociacaoUnidirecional : Form
    {
        public frm06_AssociacaoUnidirecional()
        {
            InitializeComponent();
        }

        private void btnFuncComp_Click(object sender, EventArgs e)
        {
            Computador o_Comp = new Computador();
            o_Comp.codComputador = 10;
            o_Comp.descricao = "ASUS X509";

            Funcionario o_Funcionario = new Funcionario();
            o_Funcionario.codFunc = 100;
            o_Funcionario.nome = "Maria";
           
            o_Funcionario.notebook = o_Comp; // RELACIONAMENTO

            o_Funcionario.imprimirDados();
        }

        private void btnFuncCompTablet_Click(object sender, EventArgs e)
        {
            Computador o_Comp = new Computador();
            o_Comp.codComputador = 10;
            o_Comp.descricao = "ASUS X509";

            Tablet o_Tablet = new Tablet();
            o_Tablet.codTablet = 50;
            o_Tablet.descricao = "Tablet SamSung";

             Funcionario o_Funcionario = new Funcionario();
            o_Funcionario.codFunc = 100;
            o_Funcionario.nome = "Maria";
            
            o_Funcionario.notebook = o_Comp;    // RELACIONAMENTO
            o_Funcionario.pdv = o_Tablet;       // RELACIONAMENTO

            o_Funcionario.imprimirDados();
        }

        private void btnPosJogador_Click(object sender, EventArgs e)
        {
            Jogador o_Jogador = new Jogador();
            o_Jogador.nome = "Biro Biro";
            o_Jogador.idade = 27;

            Posicao o_Posicao = new Posicao();
            o_Posicao.nome = "Meio de campo";
            o_Posicao.nroCamisa = 10;
            
            o_Posicao.jogador = o_Jogador;  // RELACIONAMENTO

            o_Posicao.imprimirDados();
        }

        private void btnArtigoAutor_Click(object sender, EventArgs e)
        {
            Autor o_Maria = new Autor();
            o_Maria.codAutor = 100;
            o_Maria.nome = "Maria";

            Autor o_Jose = new Autor();
            o_Jose.codAutor = 200;
            o_Jose.nome = "José";

            Autor o_Jesus = new Autor();
            o_Jesus.codAutor = 300;
            o_Jesus.nome = "Jesus";


            Artigo o_Artigo = new Artigo();

            o_Artigo.titulo = "Indústria 4.0";
            o_Artigo.ano = 2020;

            //-----------------------------------
            // 0..3 ou 1..3
            //-----------------------------------
            //o_Artigo.Autores[0] = o_Maria;    // RELACIONAMENTO
            //o_Artigo.Autores[1] = o_Jose;     // RELACIONAMENTO
            //o_Artigo.Autores[2] = o_Jesus;    // RELACIONAMENTO

            o_Artigo.imprimirDados();
        }

        private void btnVendedorCliente_Click(object sender, EventArgs e)
        {           
            Cliente o_Maria = new Cliente();
            o_Maria.nome = "Maria";
            o_Maria.cidade = "Batatais";

            Cliente o_Jose = new Cliente();
            o_Jose.nome = "José";
            o_Jose.cidade = "Matão";

            Cliente o_Jesus = new Cliente();
            o_Jesus.nome = "Jesus";
            o_Jesus.cidade = "Sales";

            Cliente o_Pedro = new Cliente();
            o_Pedro.nome = "Pedro";
            o_Pedro.cidade = "Itú";

            Vendedor o_Vendedor = new Vendedor();
            o_Vendedor.codVendedor = 100;
            o_Vendedor.nome = "João";

            o_Vendedor.Clientes.Add(o_Maria);   // RELACIONAMENTO
            o_Vendedor.Clientes.Add(o_Jose);    // RELACIONAMENTO
            o_Vendedor.Clientes.Add(o_Jesus);   // RELACIONAMENTO
            o_Vendedor.Clientes.Add(o_Pedro);   // RELACIONAMENTO           

            o_Vendedor.imprimirDados();

            o_Vendedor = null;

            o_Jesus.imprimirDados();
            o_Maria.imprimirDados();
        }

        private void btnAeronaveTrecho_Click(object sender, EventArgs e)
        {
            VooTrecho o_RibCam = new VooTrecho();
            o_RibCam.origem = "Rib. Preto";
            o_RibCam.destino = "Campinas";

            VooTrecho o_CamSP = new VooTrecho();
            o_CamSP.origem = "Campinas";
            o_CamSP.destino = "São Paulo";

            VooTrecho o_SPSalv = new VooTrecho();
            o_SPSalv.origem = "São Paulo";
            o_SPSalv.destino = "Salvador";

            Aeronave o_Aviao = new Aeronave();
            o_Aviao.codAeronave = 100;
            o_Aviao.modelo = "Airbus A320";

            o_Aviao.VooTrechos.Add(o_RibCam);   // RELACIONAMENTO
            o_Aviao.VooTrechos.Add(o_CamSP);    // RELACIONAMENTO
            o_Aviao.VooTrechos.Add(o_SPSalv);   // RELACIONAMENTO

            o_Aviao.imprimirDados();
        }
    }
}
