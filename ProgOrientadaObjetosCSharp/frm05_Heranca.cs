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
    public partial class frm05_Heranca : Form
    {
        public frm05_Heranca()
        {
            InitializeComponent();
        }

        private void btnHeranca_Click(object sender, EventArgs e)
        {
            Conta o_CtaMaria = new Conta();

            o_CtaMaria.NroConta = 700;
            o_CtaMaria.NomeCliente = "Maria";
            o_CtaMaria.SaldoConta = 7000.00f;            


            ContaEspecial o_CtaEspJose = new ContaEspecial();

            o_CtaEspJose.NroConta = 500;
            o_CtaEspJose.NomeCliente = "José";
            o_CtaEspJose.SaldoConta = 5000.00f;

            o_CtaMaria.imprimirDados();
            o_CtaEspJose.imprimirDados();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            Conta o_CtaMaria = new Conta();

            o_CtaMaria.NroConta = 700;
            o_CtaMaria.NomeCliente = "Maria";
            o_CtaMaria.SaldoConta = 7000.00f;


            ContaEspecial o_CtaEspJose = new ContaEspecial(500, "José", 5000f, 1000f);
                        
            o_CtaMaria.imprimirDados();
            o_CtaEspJose.imprimirDados();
        }

        private void btnVirtualOverride_Click(object sender, EventArgs e)
        {
            try
            {
                Conta o_CtaMaria = new Conta();

                o_CtaMaria.NroConta = 700;
                o_CtaMaria.NomeCliente = "Maria";
                o_CtaMaria.SaldoConta = 7000f;

                //o_CtaMaria.efetuarSaque(8000f);
                o_CtaMaria.efetuarSaque(7000f);


                ContaEspecial o_CtaEspJose = new ContaEspecial(500, "José", 7000f, 2000f);

                o_CtaEspJose.efetuarSaque(8000f);

                o_CtaMaria.imprimirDados();
                o_CtaEspJose.imprimirDados();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }           
        }

        private void btnColaboradorGer_Click(object sender, EventArgs e)
        {
            Gerente o_Gerente = new Gerente();

            o_Gerente.Nome = "José";
            o_Gerente.Cpf = "765.432-1";
            o_Gerente.Salario = 3000f;
            o_Gerente.Setor = "Administrativo";

            Console.WriteLine("Nome: " + o_Gerente.Nome);
            Console.WriteLine("CPF: " + o_Gerente.Cpf);
            Console.WriteLine("Salário: " + o_Gerente.Salario.ToString("N2"));
            Console.WriteLine("Setor: " + o_Gerente.Setor);
        }

        private void btnVeicUsado_Click(object sender, EventArgs e)
        {
            VeiculoUsado o_Gol = new VeiculoUsado();
            o_Gol.Modelo = "Gol";
            o_Gol.AnoFab = 2002;
            o_Gol.Valor = 20000f;
            o_Gol.imprimirDados();

            float vlrDepCarro;
            vlrDepCarro = o_Gol.calcularDepreciacao(20000f);
            Console.WriteLine("Valor Depreciação: " + vlrDepCarro);


            VeiculoUsado o_Vectra = new VeiculoUsado("Vectra", 2011, 25000f);
            o_Vectra.imprimirDados();

            vlrDepCarro = o_Gol.calcularDepreciacao(25000f);
            Console.WriteLine("Valor Depreciação: " + vlrDepCarro);


            CaminhaoUsado o_Volvo = new CaminhaoUsado();
            o_Volvo.Modelo = "Volvo";
            o_Volvo.AnoFab = 2015;
            o_Volvo.Valor = 50000f;
            o_Volvo.NroEixos = 4;
            o_Volvo.Capacidade = 5;
            o_Volvo.imprimirDados();

            float vlrDepCaminhao;
            vlrDepCaminhao = o_Volvo.calcularDepreciacao(50000f);
            Console.WriteLine("Valor Depreciação: " + vlrDepCaminhao);
            
            CaminhaoUsado o_GM = new CaminhaoUsado("GM", 2016, 60000f, 5, 4);
            o_GM.imprimirDados();

            vlrDepCaminhao = o_GM.calcularDepreciacao(60000f);
            Console.WriteLine("Valor Depreciação: " + vlrDepCaminhao);
        }
    }
}
