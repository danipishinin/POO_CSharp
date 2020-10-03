using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RepresComercial
{   
    private string nome;
    private string cnpj;
    private float comissao;
    private float bonus;

    public string Nome{
        get { return nome; }
        set { nome = value; }
    }
    public string Cnpj{
        get { return cnpj; }
        set { cnpj = value; }
    }
    public float Comissao {
        get { return comissao; }
        set { comissao = value; }
    }
    
    public RepresComercial()
    {
    }
    public RepresComercial(string nome, string cnpj, float comissao)
    {       
        this.nome = nome;
        this.cnpj = cnpj;
        this.comissao = comissao;
    }
        
    public virtual void imprimirDados()
    {       
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("CNPJ: " + cnpj);
        Console.WriteLine("Comissão: " + comissao.ToString("N2"));
        Console.WriteLine("Bonus: " + bonus.ToString("N2"));
    }


    public void calcularBonus(float porcentagem)
    {
        bonus = (comissao * porcentagem) / 100;
    }

    public void calcularBonus(int nroDiasTrabalhados)
    {
        float valorDia;

        valorDia = comissao / 30;

        bonus = valorDia * nroDiasTrabalhados;
    }
}