using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ImpostoRenda;




namespace ProgOrientadaObjetosCSharp
{
    public partial class frm09_ClassesAbstratasInterfaces : Form
    {
        public frm09_ClassesAbstratasInterfaces()
        {
            InitializeComponent();
        }

        private void btnAbstrataPMR_Click(object sender, EventArgs e)
        {
            float partLucrosMetalurgico, partLucrosRepresCom;

            Metalurgico o_Metal = new Metalurgico();
            o_Metal.Nome = "José";
            o_Metal.Salario = 1500f;
            o_Metal.Abono = 150f;
            partLucrosMetalurgico = o_Metal.participacaoLucros();


            RepresentanteComercial RepCom = new RepresentanteComercial();
            RepCom.Nome = "Maria";
            RepCom.Salario = 5000f;
            RepCom.Comissao = 400f;
            partLucrosRepresCom = RepCom.participacaoLucros();


            Console.WriteLine("<--- Metalúrgico --->");
            o_Metal.imprimirDados();

            Console.WriteLine("<--- Metalúrgico --->");
            RepCom.imprimirDados();


            Console.WriteLine("<--- Participação nos Lucros --->");
            Console.WriteLine("Metalúrgico: " + partLucrosMetalurgico.ToString("N2"));                      
            Console.WriteLine("Representante Comercial: " + partLucrosRepresCom.ToString("N2"));
        }

        private void btnIManIFluFran_Click(object sender, EventArgs e)
        {
            float comissao, despesas;

            Franquia o_Franq = new Franquia();

            o_Franq.local = "Ribeirão Preto";
            o_Franq.valorRetorno = 1500f;

            o_Franq.inserir();
            o_Franq.alterar();
            o_Franq.pesquisar();
            o_Franq.excluir();

            comissao = o_Franq.calcularComissao();
            despesas = o_Franq.calcularDespesas();

            Console.WriteLine("Comissão: " + comissao.ToString("N2"));
            Console.WriteLine("Despesas: " + despesas.ToString("N2"));
        }

        private void btnIManITribVeic_Click(object sender, EventArgs e)
        {
            float icmsVeic, ipiVeic;
            float icmsProd, ipiProd;

            VeiculoFab o_VeicFab = new VeiculoFab();
            o_VeicFab.modelo = "Civic";
            o_VeicFab.anoFab = 2020;

            o_VeicFab.inserir();
            o_VeicFab.alterar();
            o_VeicFab.pesquisar();
            o_VeicFab.excluir();

            icmsVeic = o_VeicFab.calcularICMS();
            ipiVeic = o_VeicFab.calcularIPI();

            Console.WriteLine("ICMS: " + icmsVeic.ToString("N2"));
            Console.WriteLine("IPI: " + ipiVeic.ToString("N2"));

           

            ProdutoFab o_ProdFab = new ProdutoFab();
            o_ProdFab.descProduto = "Roda de liga leve";
            o_ProdFab.preco = 3200f;

            o_ProdFab.inserir();
            o_ProdFab.alterar();
            o_ProdFab.pesquisar();
            o_ProdFab.excluir();

            icmsProd = o_ProdFab.calcularICMS();
            ipiProd = o_ProdFab.calcularIPI();

            Console.WriteLine("ICMS: " + icmsProd.ToString("N2"));
            Console.WriteLine("IPI: " + ipiProd.ToString("N2"));
        }

        

       
        private void btnClsEstaticasEntrada_Click(object sender, EventArgs e)
        {
            Modulo.nroAcesso = 10;
        }

        private void btnClsEstaticasSaida_Click(object sender, EventArgs e)
        {
            Modulo.imprimirNroAcesso();
        }


        private void btnNamespaceParte1_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------------
            //Forma 1
            //---------------------------------------------------------
            ImpostoMunicipal.CalcularImposto o_CalcImpMun = new ImpostoMunicipal.CalcularImposto();
            ImpostoFederal.CalcularImposto o_CalcImpFed = new ImpostoFederal.CalcularImposto();

            o_CalcImpMun.calcularVlrImposto();
            o_CalcImpFed.calcularVlrImposto();
        }

        private void btnNamespaceParte2_Click(object sender, EventArgs e)
        {
            //---------------------------------------------------------
            //Forma 2
            //---------------------------------------------------------
            CalcularIR o_CalcIR = new CalcularIR();

            o_CalcIR.calcularVlrImposto();
        }

        private void btnImpostoDevido_Click(object sender, EventArgs e)
        {
            float imposto;
            ITributacao o_ITributacao;
            ImpostoDevido o_ImpostoDevido = new ImpostoDevido();

            //-------------------------------------------------------------
            o_ITributacao = new VeiculoFab();

            imposto = o_ImpostoDevido.calculaImposto(o_ITributacao);

            Console.WriteLine("Valor a pagar Veículo: " + imposto.ToString("N2"));


            //-------------------------------------------------------------
            o_ITributacao = new ProdutoFab();

            imposto = o_ImpostoDevido.calculaImposto(o_ITributacao);

            Console.WriteLine("Valor a pagar Produto: " + imposto.ToString("N2"));
        }


        private void btnClassesABCD_Click(object sender, EventArgs e)
        {
            ClasseA o_clsA = new ClasseA();
            ClasseB o_clsB = new ClasseB();
            ClasseC o_clsC = new ClasseC();
            ClasseD o_clsD = new ClasseD();

            o_clsA.Id = 100;

            o_clsB.Id = 200;
            o_clsB.nome = "Classe B";

            o_clsC.Id = 300;
            o_clsC.nome = "Classe C";
            o_clsC.valor = 5000f;

            o_clsD.imprimirA(o_clsA);
            o_clsD.imprimirA(o_clsB);
            o_clsD.imprimirA(o_clsC);

            //o_clsD.imprimirB(o_clsA);
            //o_clsD.imprimirB(o_clsB);
            //o_clsD.imprimirB(o_clsC);

            //o_clsD.imprimirC(o_clsA);
            //o_clsD.imprimirC(o_clsB);
            //o_clsD.imprimirC(o_clsC);
        }


    }
}
