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
    public partial class frm08_DepenAgregCompAssoc : Form
    {
        public frm08_DepenAgregCompAssoc()
        {
            InitializeComponent();
        }

        private void btnConsumidorCorreios_Click(object sender, EventArgs e)
        {
            Consumidor o_Maria = new Consumidor();

            o_Maria.inserirDados(100, "Maria", "14000");

            o_Maria.imprimirDados();
        }

        private void btnConsumidorOrcamento_Click(object sender, EventArgs e)
        {
            Consumidor o_Maria = new Consumidor();
            o_Maria.inserirDados(100, "Maria", "14000");


            Orcamento o_Orcamento = new Orcamento();
            o_Orcamento.inserirDados(50, o_Maria, 2500f);

            o_Orcamento.imprimirDados();
        }

        private void btnEmprestimoConsumidor_Click(object sender, EventArgs e)
        {
            Consumidor o_Consumidor = new Consumidor();
            o_Consumidor.inserirDados(300, "José", "14400");


            Emprestimo o_Emprestimo = new Emprestimo();
            o_Emprestimo.efetuarEmprestimo(o_Consumidor, 3000, 12);


            o_Emprestimo.imprimirDados();
        }

        private void btnReuniaoFunc_Click(object sender, EventArgs e)
        {
            Funcionario o_Maria = new Funcionario();
            o_Maria.codFunc = 100;
            o_Maria.nome = "Maria";

            Funcionario o_Jose = new Funcionario();
            o_Jose.codFunc = 200;
            o_Jose.nome = "José";

            Reuniao o_Reuniao = new Reuniao();

            o_Reuniao.titulo = "Implatação de novas metodologias.";
            o_Reuniao.horario = new DateTime(2020, 2, 24);

            o_Reuniao.Participantes.Add(o_Maria);   // RELACIONAMENTO
            o_Reuniao.Participantes.Add(o_Jose);    // RELACIONAMENTO

            o_Reuniao.imprimirDados();
        }

        private void btnVendaTopoItem_Click(object sender, EventArgs e)
        {
            VendaTopo o_Venda = new VendaTopo();

            o_Venda.nf = 5577;
            o_Venda.dataVenda = new DateTime(2020, 2, 24);


            o_Venda.Itens.Add(new VendaItem() { quantidade = 3, vlrUnitario = 23.50f });
            o_Venda.Itens.Add(new VendaItem() { quantidade = 5, vlrUnitario = 35.00f });


            o_Venda.imprimirDados();
        }

        private void btnCarroMotoristaPeca_Click(object sender, EventArgs e)
        {
            Motorista o_Maria = new Motorista();
            o_Maria.nome = "Maria";
            o_Maria.idade = 20;

            Motorista o_Jose = new Motorista();
            o_Jose.nome = "José";
            o_Maria.idade = 25;


            Carro o_Carro = new Carro();
            o_Carro.marca = "Honda";
            o_Carro.modelo = "Civic";

            // Agregação
            o_Carro.condutores.Add(o_Maria);
            o_Carro.condutores.Add(o_Jose);

            // Composição
            o_Carro.pecas.Add(new Peca() { descricao = "Motor" });
            o_Carro.pecas.Add(new Peca() { descricao = "Direção" });
            o_Carro.pecas.Add(new Peca() { descricao = "Pneus" });

            o_Carro.imprimirDados();
        }

        private void btnEstudMatDisc_Click(object sender, EventArgs e)
        {
            //----------------------------------------------
            // Disciplinas
            //----------------------------------------------
            Disciplina o_POO = new Disciplina();
            o_POO.nome = "Prog. Orientada a objetos";

            Disciplina o_ED = new Disciplina();
            o_ED.nome = "Estrutura de Dados";

            Disciplina o_PWeb = new Disciplina();
            o_PWeb.nome = "Prog. Web";


            //----------------------------------------------
            // Estudantes
            //----------------------------------------------
            Estudante o_Maria = new Estudante();
            o_Maria.nome = "Maria";

            Estudante o_Jose = new Estudante();
            o_Jose.nome = "José";


            //----------------------------------------------
            // Matrículas
            //----------------------------------------------                       
            Matricula o_Matricula01 = new Matricula();
            o_Matricula01.Nro = 100;
            o_Matricula01.estudante = o_Maria;  // RELACIONAMENTO
            o_Matricula01.disciplina = o_POO;   // RELACIONAMENTO         

            Matricula o_Matricula02 = new Matricula();
            o_Matricula02.Nro = 200;
            o_Matricula02.estudante = o_Maria;  // RELACIONAMENTO
            o_Matricula02.disciplina = o_ED;    // RELACIONAMENTO

            Matricula o_Matricula03 = new Matricula();
            o_Matricula03.Nro = 300;
            o_Matricula03.estudante = o_Maria;  // RELACIONAMENTO
            o_Matricula03.disciplina = o_PWeb;  // RELACIONAMENTO

            Matricula o_Matricula04 = new Matricula();
            o_Matricula04.Nro = 400;
            o_Matricula04.estudante = o_Jose;   // RELACIONAMENTO
            o_Matricula04.disciplina = o_POO;   // RELACIONAMENTO


            //----------------------------------------------
            // Estudantes
            //----------------------------------------------
            // Relacionamento De: Estudantes   Para: Matriculas
            o_Maria.Matriculas.Add(o_Matricula01);  // RELACIONAMENTO
            o_Maria.Matriculas.Add(o_Matricula02);  // RELACIONAMENTO
            o_Maria.Matriculas.Add(o_Matricula03);  // RELACIONAMENTO
            o_Jose.Matriculas.Add(o_Matricula04);   // RELACIONAMENTO


            //----------------------------------------------
            // Disciplinas
            //----------------------------------------------
            // Relacionamento De: Disciplinas   Para: Matriculas
            o_POO.Matriculas.Add(o_Matricula01);    // RELACIONAMENTO
            o_POO.Matriculas.Add(o_Matricula04);    // RELACIONAMENTO

            o_ED.Matriculas.Add(o_Matricula02);     // RELACIONAMENTO
            o_PWeb.Matriculas.Add(o_Matricula03);   // RELACIONAMENTO


            //----------------------------------------------
            // Imprime os dados
            //----------------------------------------------
            o_Maria.imprimirDados();
            o_Jose.imprimirDados();

        }
    }
}
