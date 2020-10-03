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
    public partial class frm03_AbstracaoEncapsulamento : Form
    {
        public frm03_AbstracaoEncapsulamento()
        {
            InitializeComponent();
        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            // Instância a classe (cria um objeto da classe)
            Animal o_Cachorro = new Animal();

            // informa os valores dos atributos
            o_Cachorro.nome = "Xei de Puga";
            o_Cachorro.idade = 10;

            // Obtem os valores dos atributos
            Console.WriteLine("Nome: " + o_Cachorro.nome);
            Console.WriteLine("Idade: " + o_Cachorro.idade);


            // Instância a classe (cria um objeto da classe)
            Animal o_Gato = new Animal();
          
            o_Gato.nome = "Tigresa";
            o_Gato.idade = 5;

            Console.WriteLine("Nome: " + o_Gato.nome);
            Console.WriteLine("Idade: " + o_Gato.idade);
        }

        
        private void btnAtributosPrivados_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario o_Usuario = new Usuario();

                o_Usuario.Nome = "Maria";
                o_Usuario.AnoNasc = 1980;
                o_Usuario.Senha = "123456";

                Console.WriteLine("Nome: " + o_Usuario.Nome);
                Console.WriteLine("Data Nasc: " + o_Usuario.AnoNasc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Tratamento de Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          

        private void btnExemplo_Click(object sender, EventArgs e)
        {
            Criptografia o_Senha = new Criptografia();

            o_Senha.Dado = 100;

            Console.WriteLine("Dado: " + o_Senha.Dado);

            Console.WriteLine("Dado Criptografado: " + o_Senha.dado);
        }

        private void btnMaternidade_Click(object sender, EventArgs e)
        {
            Mae o_Juliana = new Mae();

            o_Juliana.nome = "Juliana";
            o_Juliana.endereco = "Rua x, 10";
            o_Juliana.dataNasc = 1972;
            o_Juliana.fone = "99999-7777";

            Console.WriteLine("Nome: " + o_Juliana.nome);
            Console.WriteLine("Endereço: " + o_Juliana.endereco);
            Console.WriteLine("Data Nasc: " + o_Juliana.dataNasc);
            Console.WriteLine("Fone: " + o_Juliana.fone);
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno o_Maria = new Aluno();

                o_Maria.CodAluno = 100;
                o_Maria.Nome = "Maria";
                o_Maria.NotaP1 = 9.5F;
                o_Maria.NotaP2 = 9.5F;

                Console.WriteLine("Código: " + o_Maria.CodAluno);
                Console.WriteLine("Nome: " + o_Maria.Nome);
                Console.WriteLine("Nota P1: " + o_Maria.NotaP1);
                Console.WriteLine("Nota P1: " + o_Maria.NotaP2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
