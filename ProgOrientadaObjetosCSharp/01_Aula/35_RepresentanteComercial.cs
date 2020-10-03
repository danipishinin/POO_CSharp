using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RepresentanteComercial : Pessoa
{
    //-----------------------------------------------
    //                  ATRIBUTOS
    //-----------------------------------------------    
    private float comissao;


    //-----------------------------------------------
    //                 PROPRIEDADES 
    //-----------------------------------------------
    //   NORMAL
    public float Comissao{
        get{
            return comissao;
        }
        set{
            comissao = value;
        }
    }

    // IMPLEMENTA a propriedade ParticLucros
    public override float Salario {
        get{
            return salario;
        }
        set{
            salario = value + 500f;
        }
    }

    //-----------------------------------------------
    //                   MÉTODOS 
    //-----------------------------------------------
    // SOBRESCREVE o método imprimir
    public override void imprimirDados()
    {
        base.imprimirDados();

        Console.WriteLine("Comissão: " + comissao.ToString("N2"));
    }

    // IMPLEMENTA o método participacaoLucros()
    public override float participacaoLucros()
    {
        return 500f;
    }
}

