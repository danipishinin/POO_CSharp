using System;

//========================================
using System.Collections;
using System.Collections.Generic;
//========================================

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace ProgOrientadaObjetosCSharp
{
    public partial class frm02_IntermediarioCSharp : Form
    {
        public frm02_IntermediarioCSharp()
        {
            InitializeComponent();
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alô Mundo!");

            MessageBox.Show("Alô Mundo!",
                            "Estudos Iniciais");

            MessageBox.Show("Alô Mundo!",
                            "Estudos Iniciais",
                            MessageBoxButtons.OKCancel);

            MessageBox.Show("Alô Mundo!",
                            "Estudos Iniciais",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);

        }


        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList o_ArlGeral = new ArrayList();

            // Adiciona elementos
            o_ArlGeral.Add(3);
            o_ArlGeral.Add("João");
            o_ArlGeral.Add(1.65);
            o_ArlGeral.Add(DateTime.Now);
            o_ArlGeral.Add("João");
            o_ArlGeral.Add("João");

            //Exibe todos os elementos
            foreach (Object Item in o_ArlGeral)
            {
                Console.WriteLine("Item: " + Item.ToString());
            }



            // Verifica se contem o elemento
            if (o_ArlGeral.Contains("João"))
            {
                MessageBox.Show("O Array List contem o nome: João",
                                "Pesquisa", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Array List NÃO contem o nome: João",
                                "Pesquisa", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            // Remove o primeiro João que encontrar na lista
            o_ArlGeral.Remove("João");

            MessageBox.Show("O primeiro João encontrado na lista foi removido",
                            "Remoção", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            //Exibe todos os elementos
            foreach (Object Item in o_ArlGeral)
            {
                Console.WriteLine("Item: " + Item.ToString());
            }

            // Remove todos os elementos
            o_ArlGeral.Clear();

            MessageBox.Show("Todos os itens da lista foram removidos.",
                            "Remoção", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


        }

       
        private void btnList_Click(object sender, EventArgs e)
        {
            List<int> o_lstNumeros = new List<int>();

            // Adiciona elementos
            o_lstNumeros.Add(10);
            o_lstNumeros.Add(20);
            o_lstNumeros.Add(30);
            o_lstNumeros.Add(40);
            o_lstNumeros.Add(10);
            o_lstNumeros.Add(10);


            // Exibe todos os elementos
            foreach (Object Item in o_lstNumeros)
            {
                Console.WriteLine("Item: " + Item.ToString());
            }

           
            // Remove o primeiro 10 que encontrar na lista
            o_lstNumeros.Remove(10);

            // Exibe todos os elementos da lista
            foreach (Object Item in o_lstNumeros)
            {
                Console.WriteLine("Item: " + Item.ToString());
            }
            

            // Verifica se um elemento se encontra na lista
            if (o_lstNumeros.Contains(30))
            {
                MessageBox.Show("A Lista contem o número: 30",
                                "Pesquisa", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A Lista NÃO contem o número: 30",
                                "Pesquisa", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            // Remove todos os elementos da lista
            o_lstNumeros.Clear();

        }


        private void btnHashtable_Click(object sender, EventArgs e)
        {
            Hashtable o_hstEmailAluno = new Hashtable();

            // Adiciona elementos
            o_hstEmailAluno.Add("jose.maria@google.com", "José Maria");
            o_hstEmailAluno.Add("carlosteixeira@hotmail.com", "Carlos Teixeira");
            o_hstEmailAluno.Add("pedropaulo@msn.com", "Pedro Paulo");

            //Exibe todos os elementos com BASE NA CHAVE          
            Console.WriteLine("===========  CHAVE   ===========");
            foreach (Object Item in o_hstEmailAluno.Keys)
            {
                Console.WriteLine("Item.Chave: " + Item.ToString());
            }


            //Exibe todos os elementos com BASE NO VALOR           
            Console.WriteLine("===========  VALOR   ===========");
            foreach (Object Item in o_hstEmailAluno.Values)
            {
                Console.WriteLine("Item.Valor: " + Item.ToString());
            }



            //Exibe todos os elementos INDEPENDENTE DA CHAVE OU VALOR          
            Console.WriteLine("===========  CHAVE / VALOR   ===========");
            // Cada item é um Hashtable é marmazenado em um par de chave/valor 
            // armazenado em um objeto DictionaryEntry.
            foreach (DictionaryEntry Item in o_hstEmailAluno)
            {
                Console.WriteLine(Item.Key.ToString() + " ==> " + Item.Value.ToString());
            }


            // Verifica se contem o elemento
            if (o_hstEmailAluno.Contains("pedropaulo@msn.com"))
            {
                MessageBox.Show("O Hashtable contem o email: pedropaulo@msn.com",
                                "Pesquisa", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Hashtable NÃO contem o email: pedropaulo@msn.com",
                                "Pesquisa", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            // Remove o elemento com base na sua CHAVE
            o_hstEmailAluno.Remove("pedropaulo@msn.com");

            //Exibe todos os elementos INDEPENDENTE DA CHAVE OU VALOR          
            Console.WriteLine("===========  CHAVE / VALOR   ===========");
            // Cada item é um Hashtable é marmazenado em um par de chave/valor 
            // armazenado em um objeto DictionaryEntry.
            foreach (DictionaryEntry Item in o_hstEmailAluno)
            {
                Console.WriteLine(Item.Key.ToString() + " ==> " + Item.Value.ToString());
            }


            // Remove todos os elementos
            o_hstEmailAluno.Clear();

            MessageBox.Show("Todos os itens foram removidos.",
                            "Remoção", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }



        private void btnFuncSemRet_Click(object sender, EventArgs e)
        {
            msgBoasVindas();
        }

        private void msgBoasVindas()
        {
            Console.WriteLine("Alô Mundo!");
        }

        private void btnFuncComRet_Click(object sender, EventArgs e)
        {
            int resultado;

            resultado = soma(10, 10);

            Console.WriteLine("Total: " + resultado);

        }

        private static int soma(int vlr1, int vlr2)
        {
            int total;

            total = vlr1 + vlr2;

            return total;
        }

        private void bttnModulo_Click(object sender, EventArgs e)
        {
            Modulo.nroAcesso = 10;

            Modulo.imprimirNroAcesso();
        }

        private void btnErros_Click(object sender, EventArgs e)
        {
            int x, total;

            x = 0;

            total = 100 / x;

            Console.WriteLine("Resultado: " + total);
        }

        private void btnErroComTratamento_Click(object sender, EventArgs e)
        {
            try
            {
                int x, total;

                x = 0;

                total = 100 / x;

                Console.WriteLine("Resultado: " + total);
            }
            catch
            {
                MessageBox.Show("Não é possível divisão por zero.",
                                "Tratamento de Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);               
            }
        }

        private void btnErroComException_Click(object sender, EventArgs e)
        {
            try
            {
                int x, total;

                x = 0;

                total = 100 / x;

                Console.WriteLine("Resultado: " + total);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                                "Tratamento de Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnLancException_Click(object sender, EventArgs e)
        {
            try {
                int x, total;

                x = 0;

                if (x == 0)
                {
                    throw new Exception("O valor de X deve ser maior que zero.");
                }

                total = 100 / x;

                Console.WriteLine("Resultado: " + total);
            }
            catch (Exception ex){
                MessageBox.Show("Erro: " + ex.Message, "Tratamento de Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random o_Rand = new Random();
            int vlrRand;

            vlrRand = o_Rand.Next(0, 100);
           
            Console.WriteLine("Valor aleatório: " + vlrRand);
        }

        private void btnListExercicio_Click(object sender, EventArgs e)
        {
            List<string> m_lstStarWars = new List<string>();

            // Adiciona um elemento
            m_lstStarWars.Add("Luke Skywalker");
            m_lstStarWars.Add("Darth Vader");
            m_lstStarWars.Add("Han Solo");
            m_lstStarWars.Add("Chewbacca");

            // Exibe todos os elementos da lista
            foreach (Object Item in m_lstStarWars)
            {
                Console.WriteLine("Item: " + Item.ToString());
            }

            // Remove o item
            m_lstStarWars.Remove("Chewbacca");

            // Adiciona itens na lista
            m_lstStarWars.Add("Lea Organa");
            m_lstStarWars.Add("R2D2");
            m_lstStarWars.Add("C3PO");
            m_lstStarWars.Add("BB8");

            // Verifica se um elemento se encontra na lista
            if (m_lstStarWars.Contains("Han Solo"))
            {
                MessageBox.Show("Han Solo – Positivo Operante",
                                "Pesquisa", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Han Solo – Inativo",
                                "Pesquisa", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            Console.WriteLine("\n\n\n");

            // Exibe todos os elementos da lista
            foreach (Object Item in m_lstStarWars)
            {
                Console.WriteLine("Novos Itens: " + Item.ToString());
            }
        }
    }
}
