using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Consumidor
{
    public int codConsumidor;
    public string nome;
    public string cep;
    public string cidade;

    public void inserirDados(int codConsumidor, string nome, string cep)
    {
        Correios o_correio = new Correios();

        this.codConsumidor = codConsumidor;
        this.nome = nome;
        this.cep = cep;
        cidade = o_correio.obterCidade(cep);
    }

    public void imprimirDados()
    {
        Console.WriteLine("Código: " + codConsumidor);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("CEP: " + cep);
        Console.WriteLine("Cidade: " + cidade);
    }
}

