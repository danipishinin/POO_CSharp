using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Gerente : Colaborador
{
    private string setor;

    public string Setor
    {
        get { return setor; }
        set { setor = value; }
    }

    public override float calcularPLR()
    {
        float resultado;
        resultado = salario * 0.10f;

        return resultado;
    }

    public override void imprimir()
    {
        base.imprimir();
        System.Console.WriteLine("Setor: " + setor);
    }
}

