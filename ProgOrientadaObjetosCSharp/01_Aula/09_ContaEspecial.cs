using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ContaEspecial : Conta
{

    // Atributos (estado)
    private float limiteCta;

    // Propriedades
    public float LimiteCta
    {
        get => limiteCta;
        set => limiteCta = value;
    }

    
    public ContaEspecial()
    { 

    }

   
    public ContaEspecial(int nroConta, string nomeCliente, float saldoConta, float limiteCta)
    {
        base.nroConta = nroConta;
        base.nomeCliente = nomeCliente;
        base.saldoConta = saldoConta;
        this.limiteCta = limiteCta;
    }


    public override void efetuarSaque(float vlrSaque)
    {
        float totalSaldo;

        totalSaldo = saldoConta + limiteCta;

        if (vlrSaque > totalSaldo)
        {
            throw new Exception("Saldo insuficiente para o saque!");            
        }
        else
        {
            saldoConta -= vlrSaque;
        }
    }

    public void imprimirDados()
    {
        base.imprimirDados();
        Console.WriteLine("Limite Conta: " + limiteCta);
        
    }

}

