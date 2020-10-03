using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Professor
{
    // Atributos
    public string nome;
    public int idade;
    private List<Professor> professores;   // 0...*  // RELACIONAMENTO
    public Professor coordenador;          // RELACIONAMENTO

    // Propriedades
    public List<Professor> Professores {
        get{
            if (professores == null){
                professores = new List<Professor>();
            }
            return professores;
        }
        set{
            if (professores == null){
                professores = new List<Professor>();
            }
            professores = value;
        }
    }    

    public void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);

        if (coordenador != null)
        {
            Console.WriteLine("\t Coordenador: " + coordenador.nome);
            Console.WriteLine("\t Idade: " + coordenador.idade);
        }


            if (professores != null)
        {
            foreach (Professor item in professores)
            {
                Console.WriteLine("\t Nome: " + item.nome);
                Console.WriteLine("\t Idade: " + item.idade);
            }
        }
    }
}

