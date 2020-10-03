using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Financeiro
{
    private float saldoCaixa;
    private DateTime inicioAcesso;  
    private DateTime fimAcesso;

    // Construtor
    public Financeiro()
    {
        Console.WriteLine("<---  CONSTRUTOR  --->");
        inicioAcesso = DateTime.Now;        
    }

    // Propriedades
    public float SaldoCaixa{
        get{
            return saldoCaixa;
        }
        set{
            saldoCaixa = value;
        }
    }

    // Destrutor 
    ~Financeiro()
    {
        fimAcesso = DateTime.Now;

        Console.WriteLine("<---  DESTRUTOR  --->");
        Console.WriteLine("Acesso Início: \t" + inicioAcesso);
        Console.WriteLine("Acesso Fim: \t" + fimAcesso);
    }
}



