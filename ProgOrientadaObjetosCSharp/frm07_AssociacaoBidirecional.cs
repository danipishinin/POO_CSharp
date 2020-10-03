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
    public partial class frm07_AssociacaoBidirecional : Form
    {
        public frm07_AssociacaoBidirecional()
        {
            InitializeComponent();
        }

        private void btnGovEstado_Click(object sender, EventArgs e)
        {
            Governador o_Gov = new Governador();
            
            o_Gov.nome = "Ivan Pires";
            o_Gov.cpf = "111.222-3";

            Estado o_Estado = new Estado();
            o_Estado.nome = "São Paulo";
            o_Estado.uf = "SP";

            // De Governador para Estado
            o_Gov.estado = o_Estado;        // RELACIONAMENTO
            
            // De Estado para Governador
            o_Estado.governador = o_Gov;    // RELACIONAMENTO


            Console.WriteLine("<--- GOVERNADOR --->");
            o_Gov.imprimirDados();

            Console.WriteLine("<--- ESTADO --->");
            o_Estado.imprimirDados();
        }

        private void btnPacienteCartao_Click(object sender, EventArgs e)
        {
            Cartao o_Cartao = new Cartao();
            o_Cartao.convenio = "Unimed";
            o_Cartao.tipo = "Master Plus";


            Paciente o_Paciente = new Paciente();
            o_Paciente.nome = "Maria";
            o_Paciente.fone = "4444-5555";

            // De Paciente para Cartão
            o_Paciente.cartao = o_Cartao;       // RELACIONAMENTO

            // De Cartão para Paciente
            o_Cartao.paciente = o_Paciente;     // RELACIONAMENTO



            Console.WriteLine("<--- PACIENTE --->");
            o_Paciente.imprimirDados();

            Console.WriteLine("<--- CARTÃO --->");
            o_Cartao.imprimirDados();
        }

        private void btnMontadoraVeic_Click(object sender, EventArgs e)
        {
            Veiculo o_Civic = new Veiculo();
            o_Civic.modelo = "Civic";
            o_Civic.nroPortas = 4;

            Veiculo o_City = new Veiculo();
            o_City.modelo = "City";
            o_City.nroPortas = 4;

            Veiculo o_Fit = new Veiculo();
            o_Fit.modelo = "Fit";
            o_Fit.nroPortas = 4;


            Montadora o_Montadora = new Montadora();
            o_Montadora.codMontadora = 100;
            o_Montadora.nome = "Honda";

            // De Montadora para Veículo
            o_Montadora.Veiculos.Add(o_Civic);  // RELACIONAMENTO
            o_Montadora.Veiculos.Add(o_City);   // RELACIONAMENTO
            o_Montadora.Veiculos.Add(o_Fit);    // RELACIONAMENTO

            // De Veículo para Montadora
            o_Civic.montadora = o_Montadora;    // RELACIONAMENTO
            o_City.montadora = o_Montadora;     // RELACIONAMENTO
            o_Fit.montadora = o_Montadora;      // RELACIONAMENTO           


            Console.WriteLine("<--- MONTADORA --->");
            o_Montadora.imprimirDados();

            Console.WriteLine("<--- VEÍCULOS --->");
            o_Civic.imprimirDados();
            o_City.imprimirDados();
            o_Fit.imprimirDados();
        }

        private void btnPropImovel_Click(object sender, EventArgs e)
        {
            Imovel o_ImovelX = new Imovel();
            o_ImovelX.endereco = "Rua X, 33";
            o_ImovelX.aluguel = 1500f;

            Imovel o_ImovelY = new Imovel();
            o_ImovelY.endereco = "Rua Y, 12";
            o_ImovelY.aluguel = 3600f;

            Proprietario o_Prop = new Proprietario();
            o_Prop.nome = "José";
            o_Prop.fone = "7777-8888";

            // De Proprietário para Imóveis
            o_Prop.Imoveis.Add(o_ImovelX);      // RELACIONAMENTO
            o_Prop.Imoveis.Add(o_ImovelY);      // RELACIONAMENTO

            // De Imóveis para Proprietário
            o_ImovelX.proprietario = o_Prop;    // RELACIONAMENTO
            o_ImovelY.proprietario = o_Prop;    // RELACIONAMENTO

            Console.WriteLine("<--- PROPRIETÁRIO --->");
            o_Prop.imprimirDados();

            Console.WriteLine("<--- IMÓVEIS --->");
            o_ImovelX.imprimirDados();
            o_ImovelY.imprimirDados();
        }

        private void btnRegCivil_Click(object sender, EventArgs e)
        {
            RegistroCivil o_Marido = new RegistroCivil();
            o_Marido.nome = "José";
            o_Marido.idade = 25;

            RegistroCivil o_Esposa = new RegistroCivil();
            o_Esposa.nome = "Maria";
            o_Esposa.idade = 20;

            // De Marido para Esposa
            o_Marido.conjuge = o_Esposa;    // RELACIONAMENTO

            // De Esposa para Marido
            o_Esposa.conjuge = o_Marido;    // RELACIONAMENTO


            Console.WriteLine("<--- MARIDO --->");
            o_Marido.imprimirDados();

            Console.WriteLine("<--- ESPOSA --->");
            o_Esposa.imprimirDados();
        }

        private void btnProfCoordenador_Click(object sender, EventArgs e)
        {
            Professor o_Maria = new Professor();
            o_Maria.nome = "Maria";
            o_Maria.idade = 45;

            Professor o_Jose = new Professor();
            o_Jose.nome = "José";
            o_Jose.idade = 50;

            Professor o_Pedro = new Professor();
            o_Pedro.nome = "Pedro";
            o_Pedro.idade = 70;

            Professor o_Coordenador = new Professor();
            o_Coordenador.nome = "Jesus";
            o_Coordenador.idade = 33;

            // De Coordenador para Professores
            o_Coordenador.Professores.Add(o_Maria);     // RELACIONAMENTO
            o_Coordenador.Professores.Add(o_Jose);      // RELACIONAMENTO
            o_Coordenador.Professores.Add(o_Pedro);     // RELACIONAMENTO

            // De Professores para Coordenador
            o_Maria.coordenador = o_Coordenador;        // RELACIONAMENTO
            o_Jose.coordenador = o_Coordenador;         // RELACIONAMENTO
            o_Pedro.coordenador = o_Coordenador;        // RELACIONAMENTO

            Console.WriteLine("<--- COORDENADOR --->");
            o_Coordenador.imprimirDados();

            Console.WriteLine("<--- PROFESSORES --->");            
            o_Maria.imprimirDados();            
            o_Jose.imprimirDados();            
            o_Pedro.imprimirDados();
        }

        private void btnEmpresaFilial_Click(object sender, EventArgs e)
        {
            Empresa o_Filial_MG = new Empresa();
            o_Filial_MG.nome = "Figorífico MG";
            o_Filial_MG.cnpj = "222.333-4";

            Empresa o_Filial_RJ = new Empresa();
            o_Filial_RJ.nome = "Figorífico RJ";
            o_Filial_RJ.cnpj = "444.555-6";


            Empresa o_Matriz = new Empresa();
            o_Matriz.nome = "Figorífico Ex-Touro";
            o_Matriz.cnpj = "111.222-3";

            // De Matriz para Filiais
            o_Matriz.Filiais.Add(o_Filial_MG);      // RELACIONAMENTO
            o_Matriz.Filiais.Add(o_Filial_RJ);      // RELACIONAMENTO

            Console.WriteLine("<--- MATRIZ-FILIAIS --->");
            o_Matriz.imprimirDados();
        }
    }
}
