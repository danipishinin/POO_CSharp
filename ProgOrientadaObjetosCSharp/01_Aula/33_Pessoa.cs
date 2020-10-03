using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Pessoa
{
    //-----------------------------------------------
    //                  ATRIBUTOS
    //-----------------------------------------------
    // Atributos NÃO PODEM ser abstratos
    protected string nome;
    protected float salario;


    //-----------------------------------------------
    //                PROPRIEDADES 
    //-----------------------------------------------
    //   NORMAL
    public string Nome { 
        get {
            return nome;
        }
        set {
            nome = value;
        }
    }

    //   ABSTRATO
    public abstract float Salario { get; set; }


    //-----------------------------------------------
    //                   MÉTODOS 
    //-----------------------------------------------   
    //   VIRTUAL
    public virtual void imprimirDados()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário Base: " + salario.ToString("N2"));        
    }

    //   ABSTRATO
    public abstract float participacaoLucros();

}

