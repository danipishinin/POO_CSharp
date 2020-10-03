using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Posicao
{
    public string nome;
    public int nroCamisa;
    public Jogador jogador;  // RELACIONAMENTO

    public void imprimirDados()
    {
        Console.WriteLine("Posição: " + nome);
        Console.WriteLine("Nro Camisa: " + nroCamisa);
        Console.WriteLine("Jogador: " + jogador.nome);
        Console.WriteLine("Idade: " + jogador.idade);
    }
}


