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
    public partial class frm01_IntroducaoCSharp : Form
    {

        public const float PI = 3.1415f;

        //==============================================
        // não pode marcar como static porque por 
        // padrão const é static
        //==============================================
        //public static const float PI = 3.1415f;
        //==============================================


        public frm01_IntroducaoCSharp()
        {
            InitializeComponent();
        }




        private void btnExecutar_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Alô Mundo!");

        }




        private void btnVariaveis_Click(object sender, EventArgs e)
        {

            int qtdeAluno = 100000;
            Console.WriteLine(qtdeAluno);

            long nroCarrosVendidos = 15000000000L;
            Console.WriteLine(nroCarrosVendidos);

            float notaAluno = 8.75F;
            Console.WriteLine(notaAluno);

            double valorNutricional = 19.99D;
            Console.WriteLine(valorNutricional);

            bool isProdutoAtivoEstoque = true;
            Console.WriteLine(isProdutoAtivoEstoque);

            char mediaAluno = 'B';
            Console.WriteLine(mediaAluno);

            string saudacao = "Alô Mundo!";
            Console.WriteLine(saudacao);

        }



        private void btnFormatacao_Click(object sender, EventArgs e)
        {
            float notaConcurso = 98.123F;
            float premiacao = 50000.00F;

            // Define o nro de casas decimais
            Console.WriteLine("Nota do vencedor: " + notaConcurso.ToString("N1"));
            Console.WriteLine("Nota do vencedor: " + notaConcurso.ToString("N2"));
            Console.WriteLine("Nota do vencedor: " + notaConcurso.ToString("N3"));

            // Formata em notação de moeda
            Console.WriteLine("Premiação: " + premiacao.ToString("C"));
        }



        private void btnConstantes_Click(object sender, EventArgs e)
        {
            float circunferencia;
            int diametro;

            diametro = 20;

            circunferencia = PI * diametro;

            Console.WriteLine("A circunferência é: " + circunferencia);
        }



        private void btnEstrCondicional01_Click(object sender, EventArgs e)
        {
            float media;

            media = 6;

            if (media >= 6)
            {
                Console.WriteLine("O aluno passou de ano.");
            }
            else
            {
                Console.WriteLine("O aluno reprovou de ano.");
            }

        }

        private void btnEstrCondicional02_Click(object sender, EventArgs e)
        {
            float media;
            string msg;

            media = 8;

            msg = media >= 6 ? "O aluno passou de ano." : "O aluno reprovou de ano.";

            Console.WriteLine(msg);

        }

        private void btnEstrCondicional03_Click(object sender, EventArgs e)
        {
            int horas = 10;

            if (horas < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (horas < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }


        private void btnEstrRepFOR_Click(object sender, EventArgs e)
        {
            int ind;

            for (ind = 0; ind < 10; ind++)
            {
                Console.WriteLine("FOR ==> Índice: " + ind);
            }
        }




        private void btnEstrRepForeach_Click(object sender, EventArgs e)
        {
            string[] carros = { "Chevrolet", "Hyundai", "Ford", "Fiat" };

            foreach (string car in carros)
            {
                Console.WriteLine(car);
            }
        }



        private void btnEstrRepWHILE_Click(object sender, EventArgs e)
        {
            int ind;

            ind = 0;

            while (ind < 10)
            {
                Console.WriteLine("WHILE ==> Índice: " + ind);
                ind++;
            }
        }

        private void btnEstrRepDO_WHILE_Click(object sender, EventArgs e)
        {
            int ind;

            ind = 0;

            do
            {
                Console.WriteLine("DO... WHILE ==> Índice: " + ind);
                ind++;

            } while (ind < 10);
        }


        private void btnBreak_Click(object sender, EventArgs e)
        {
            int ind;

            for (ind = 0; ind < 10; ind++)
            {
                if (ind == 5)
                {
                    break;
                }

                Console.WriteLine("Índice: " + ind);
            }
            Console.WriteLine("Fim do laço de repetição...");
        }


        private void btnContinue_Click(object sender, EventArgs e)
        {
            int ind;

            for (ind = 0; ind < 10; ind++)
            {
                // Nros pares não serão impressos
                if ((ind % 2) == 0)
                {
                    continue; //Desvia o código para o for
                }

                Console.WriteLine("Índice: " + ind);
            }

            Console.WriteLine("Fim do laço de repetição...");
        }


        private void btnVetores_Click(object sender, EventArgs e)
        {
            // Primeira forma
            //float[] notaAluno = new float[4];

            // Segunda forma
            float[] notaAluno;
            notaAluno = new float[4];

            notaAluno[0] = 8.0f; // P1 -  Avaliação
            notaAluno[1] = 2.0f; // T1 - Trabalho
            notaAluno[2] = 7.5f; // P2 -  Avaliação
            notaAluno[3] = 1.5f; // T2 - Trabalho

            Console.WriteLine("P1 -  Avaliação: " + notaAluno[0].ToString("N2"));
            Console.WriteLine("T1 - Trabalho: " + notaAluno[1].ToString("N2"));
            Console.WriteLine("P2 -  Avaliação: " + notaAluno[2].ToString("N2"));
            Console.WriteLine("T2 - Trabalho: " + notaAluno[3].ToString("N2"));
        }


        private void btnVetoresInicializacao_Click(object sender, EventArgs e)
        {
            // Primeira forma
            //float[] notaAluno = new float[] { 8.0f, 2.0f, 7.5f, 1.5f };

            // Segunda forma
            float[] notaAluno = { 8.0f, 2.0f, 7.5f, 1.5f };

            Console.WriteLine("P1 -  Avaliação: " + notaAluno[0].ToString("N2"));
            Console.WriteLine("T1 - Trabalho: " + notaAluno[1].ToString("N2"));
            Console.WriteLine("P2 -  Avaliação: " + notaAluno[2].ToString("N2"));
            Console.WriteLine("T2 - Trabalho: " + notaAluno[3].ToString("N2"));
        }
    }
}



