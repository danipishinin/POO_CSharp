using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Metalurgico: Pessoa
{
    //-----------------------------------------------
    //                  ATRIBUTOS
    //-----------------------------------------------    
    private float abono;


    //-----------------------------------------------
    //                 PROPRIEDADES 
    //-----------------------------------------------
    //   NORMAL
    public float Abono{
        get{
            return abono;
        }
        set{
            abono = value;
        }
    }

    // IMPLEMENTA a propriedade ParticLucros
    public override float Salario{
        get{
            return salario;
        }
        set{
            salario = value;
        }
    }

    //-----------------------------------------------
    //                   MÉTODOS 
    //-----------------------------------------------   
    // SOBRESCREVE o método imprimir
    public override void imprimirDados()
    {
        base.imprimirDados();
      
        Console.WriteLine("Abono: " + abono.ToString("N2"));
    }


    // IMPLEMENTA o método participacaoLucros()
    public override float participacaoLucros()
    {
        return 100f;
    }
}

