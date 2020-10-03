using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Reuniao
{   
    public string titulo;
    public DateTime horario;
    private List<Funcionario> participantes;     // RELACIONAMENTO

    public List<Funcionario> Participantes
    {
        get
        {
            if (participantes == null)
            {
                participantes = new List<Funcionario>();
            }

            return participantes;
        }
        set
        {
            if (participantes == null)
            {
                participantes = new List<Funcionario>();
            }

            participantes = value;
        }
    }

    public void imprimirDados()
    {       
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Horário: " + horario);

        if (participantes != null)
        {
            foreach (Funcionario item in participantes)
            {
                Console.WriteLine("\t Nome: " + item.nome);
            }
        }
    }
}

