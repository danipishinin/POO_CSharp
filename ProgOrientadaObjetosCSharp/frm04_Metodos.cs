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
    public partial class frm04_Metodos : Form
    {
        public frm04_Metodos()
        {
            InitializeComponent();
        }

        private void btnMetodos_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario o_Usuario = new Usuario();

                o_Usuario.Nome = "Maria";
                o_Usuario.AnoNasc = 1980;
                o_Usuario.Senha = "123456";

                // Imprime os dados do usuário
                o_Usuario.imprimirDados();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Tratamento de Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMetodosLivro_Click(object sender, EventArgs e)
        {
            Livro o_ArteGuerra = new Livro();
            float desconto;

            o_ArteGuerra.Titulo = "A Arte da Guerra";
            o_ArteGuerra.Preco = 100.00F;

            o_ArteGuerra.imprimirDados();

            desconto = o_ArteGuerra.efetuarDesconto(10);
            Console.WriteLine("Valor com desconto: " + desconto);

            o_ArteGuerra.efetuarVenda(5);

            o_ArteGuerra.imprimirDados();
        }

        
        private void btnThis_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario o_Jose = new Usuario();

                o_Jose.Nome = "Jose";
                o_Jose.AnoNasc = 1970;
                o_Jose.Senha = "AAABBB";

                // Altera senha
                o_Jose.alterarSenha("CCCDDD");

                MessageBox.Show("Senha alterada com sucesso!",
                                "Alteração de senha");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Tratamento de Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThisLivro_Click(object sender, EventArgs e)
        {
            Livro o_Biblia = new Livro();

            o_Biblia.Titulo = "Bíblia";
            o_Biblia.Preco = 80.50F;

            o_Biblia.alterarQtdeEstoque(200);

            o_Biblia.imprimirDados();

            o_Biblia.alterarPreco(75.00F);

            o_Biblia.imprimirDados();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            Financeiro o_CtrlCaixa = new Financeiro();

            o_CtrlCaixa.SaldoCaixa = 5000.00F;
        }


        private void btnPolimorfismo_Click(object sender, EventArgs e)
        {
            int vInt1 = 100;
            int vInt2 = 200;
            float vFloat1 = 50.50f;
            float somaRetorno;

            Calculadora o_Calculadora = new Calculadora();

            o_Calculadora.soma(10, 10);
            o_Calculadora.soma(vInt1, vInt2);

            o_Calculadora.soma(vFloat1, vInt1);
            o_Calculadora.soma(vFloat1, vInt1, 100.4f);

            somaRetorno = o_Calculadora.soma(vFloat1, vFloat1, vFloat1);
            Console.WriteLine("Total: " + somaRetorno);
        }

        private void btnSobrecargaMetodos_Click(object sender, EventArgs e)
        {
            Carpete o_CarpRusso = new Carpete();

            o_CarpRusso.encomendarCarpete(3.5F, 5.5F);


            Carpete o_CarpJapones = new Carpete();

            o_CarpJapones.encomendarCarpete(5, 10);


            Console.WriteLine("Área Carpete Russo: " + o_CarpRusso.Area + " m2");
            Console.WriteLine("Área Carpete Japonês: " + o_CarpJapones.Area + " m2");
        }

       

        private void btnCarpeteSobrecargaConstrutores_Click(object sender, EventArgs e)
        {
            Carpete o_CarpIsrael = new Carpete();

            Carpete o_CarpArabe = new Carpete(3);

            Carpete o_CarpPersia = new Carpete(4, 4);

            Console.WriteLine("Área Carpete Israel: " + o_CarpIsrael.Area + " m2");
            Console.WriteLine("Área Carpete Árabe: " + o_CarpArabe.Area + " m2");
            Console.WriteLine("Área Carpete Pérsia: " + o_CarpPersia.Area + " m2");
        }
        
        private void btnExercicioMetodos_Click(object sender, EventArgs e)
        {
            RepresComercial o_MariaME = new RepresComercial();

            o_MariaME.Nome = "Maria ME";
            o_MariaME.Cnpj = "789.000-7";
            o_MariaME.Comissao = 6000F;

            o_MariaME.calcularBonus(49.9F);
            o_MariaME.imprimirDados();

            o_MariaME.calcularBonus(10);
            o_MariaME.imprimirDados();
        }

        private void btnExercicioConstrutores_Click(object sender, EventArgs e)
        {
            RepresComercial o_EdsonME = new RepresComercial();

            o_EdsonME.Nome = "Edson ME";
            o_EdsonME.Cnpj = "123.000-2";
            o_EdsonME.Comissao = 2500.50F;

            o_EdsonME.imprimirDados();

            RepresComercial o_FatimaME = new RepresComercial("Edson ME", "456.000-9", 4500F);

            o_FatimaME.imprimirDados();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Produto o_Prod1 = new Produto();
            float vlrImposto;


            o_Prod1.CodProduto = 100;
            o_Prod1.Descricao = "TV 4k";
            o_Prod1.Preco = 1000.00f;

            System.Console.WriteLine("Código: " + o_Prod1.CodProduto);
            System.Console.WriteLine("Descrição: " + o_Prod1.Descricao);
            System.Console.WriteLine("Preço: " + o_Prod1.Preco.ToString("N2"));

            o_Prod1.aumentarPreco(10);
            vlrImposto = o_Prod1.calcularImposto(10);

            System.Console.WriteLine("Novo Preço: " + o_Prod1.Preco.ToString("N2"));
            System.Console.WriteLine("Imposto: " + vlrImposto.ToString("N2"));
        }
    }
}
