using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Conta
{
    // Atributos (estado)  
    protected int nroConta;
    protected string nomeCliente;
    protected float saldoConta;

    // Propriedades
    public int NroConta
    {
        get
        {
            return nroConta;
        }
        set
        {
            nroConta = value;
        }
    }

    public string NomeCliente
    {
        get
        {
            return nomeCliente;
        }
        set
        {
            nomeCliente = value;
        }
    }

    public float SaldoConta
    {
        get
        {
            return saldoConta;
        }
        set
        {
            saldoConta = value;
        }
    }

    public void efetuarDeposito(float valor)
    {
        saldoConta += valor;        
    }

    public virtual void efetuarSaque(float vlrSaque)
    {
        if (vlrSaque > saldoConta)
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
        Console.WriteLine("Nro Conta: " + nroConta);
        Console.WriteLine("Nome: " + nomeCliente);
        Console.WriteLine("Saldo: " + saldoConta);
    }

}

