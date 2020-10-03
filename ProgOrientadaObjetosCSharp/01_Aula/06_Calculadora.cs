using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Calculadora
{
    public void soma(int nro1, int nro2)
    {
        int total;
        total = nro1 + nro2;
        Console.WriteLine("Total: " + total);
    }

    public void soma(float nro1, float nro2)
    {
        float total;
        total = nro1 + nro2;
        Console.WriteLine("Total: " + total);
    }

    public void soma(float nro1, int nro2, float nro3)
    {
        float total;
        total = nro1 + (float)nro2 + nro3;
        Console.WriteLine("Total: " + total);
    }

    public float soma(float nro1, float nro2, float nro3)
    {
        float total;
        total = nro1 + nro2;
        Console.WriteLine("Total: " + total);
        return 10.5f;
    }
}

