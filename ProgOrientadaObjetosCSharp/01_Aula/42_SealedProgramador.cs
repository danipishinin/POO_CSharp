using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public sealed class Programador : Usuario
{
    public void simularAumentoSalario(float salario, float taxaAumento)
    {
        float Total;

        Total = (salario * taxaAumento) + 100f;

        Console.WriteLine("Resultado da simulação: " + Total.ToString("N2"));
    }
}


//public class AnalistaSistema : Programador
//{

//}


