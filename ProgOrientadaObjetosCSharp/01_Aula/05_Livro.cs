using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Livro
{
    private string titulo;    
    private float preco;
    private int qtdeEstoque = 50;

    public string Titulo{
        get{
            return titulo;
        }
        set{
            titulo = value;
        }
    }

    public float Preco{
        get{
            return preco;
        }
        set{
            preco = value;
        }
    }    

    public float efetuarDesconto(float porcentagem)
    {
        float desconto;

        desconto = preco - ((preco * porcentagem) / 100);

        return desconto;
    }

    public void efetuarVenda(int qtdeVendida)
    {
        qtdeEstoque -= qtdeVendida;
    }

    public void imprimirDados()
    {
        Console.WriteLine("============================");
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Preço: " + preco);
        Console.WriteLine("Qtde Estoque: " + qtdeEstoque);
        Console.WriteLine("============================");
    }

    
    public void alterarQtdeEstoque(int qtdeEstoque)
    {
        this.qtdeEstoque = qtdeEstoque;
    }

    public void alterarPreco(float preco)
    {
        this.preco = preco;
    }
}

