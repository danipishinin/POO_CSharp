using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Colaborador
{    
    protected string nome;
    protected string cpf;
    protected float salario;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Cpf
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public float Salario
    {
        get { return salario; }
        set { salario = value; }
    }


    public Colaborador()
    {
    }

    public Colaborador(int codColab, string nome, string cpf, float salario)
    {        
        this.nome = nome;
        this.cpf = cpf;
        this.salario = salario;
    }

    public virtual float calcularPLR()
    {
        float resultado;
        resultado = salario * 0.10f;

        return resultado;
    }

    public virtual void imprimir()
    {       
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("CPF: " + cpf);
        Console.WriteLine("Salário: " + salario.ToString("N2"));
    }
}

