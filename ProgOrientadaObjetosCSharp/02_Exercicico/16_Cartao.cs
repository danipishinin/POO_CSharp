using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cartao
{
    public string convenio;
    public string tipo;
    public Paciente paciente;   // RELACIONAMENTO

    public void imprimirDados()
    {
        Console.WriteLine("Convênio: " + convenio);
        Console.WriteLine("Tipo: " + tipo);

        if (paciente != null)
        {
            Console.WriteLine("\t Nome: " + paciente.nome);
            Console.WriteLine("\t Fone: " + paciente.fone);
        }
    }
}

