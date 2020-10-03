using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Produto
{
    private int codProduto;
    private string descricao;
    private float preco;
    //private int qtdeEstoque;   // EXERCÍCIO 2

    //--------------------------------
    // EXERCÍCIO 2
    //--------------------------------
    //public Produto()
    //{
    //    qtdeEstoque = 10;

    //    Console.WriteLine("================================================");
    //    Console.WriteLine("Qtde do produto em estoque: " + qtdeEstoque);
    //    Console.WriteLine("================================================");
    //}

    public int CodProduto
    {
        get { return codProduto; }
        set { codProduto = value;}
    }

    public string Descricao
    {
        get { return descricao; }
        set { descricao = value;}       
    }

    public float Preco
    {
        get { return preco; }
        set { preco = value;}        
    }
    
    public void aumentarPreco(float porcentagem)
    {
        float vlrAumento;

        vlrAumento = preco * (porcentagem / 100);

        preco += vlrAumento;
    }

    public float calcularImposto(float porcentagem)
    {
        float imposto;

        imposto = preco * (porcentagem / 100);

        return imposto;
    }

    //--------------------------------
    // EXERCÍCIO 2
    //--------------------------------
    //public void vendaProduto(int qtde)
    //{
    //    qtdeEstoque -= qtde;
    //}

    //~Produto()
    //{
    //    if (qtdeEstoque < 5)
    //    {
    //        Console.WriteLine("================================================");
    //        Console.WriteLine("Qtde do produto abaixo do limite mínimo: " + qtdeEstoque);
    //        Console.WriteLine("================================================");
    //    }
    //}
}



