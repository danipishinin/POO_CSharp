using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ProdutoFab: IManutencao, ITributacao
{
    public string descProduto;
    public float preco;

    //-----------------------------------------------
    //                  IManutencao  
    //-----------------------------------------------   
    public void inserir() {
        Console.WriteLine("Inserido com sucesso!");
    }

    public void alterar() {
        Console.WriteLine("Alterado com sucesso!");
    }

    public void pesquisar() {
        Console.WriteLine("Pesquisado com sucesso!");
    }

    public void excluir() {
        Console.WriteLine("Excluido com sucesso!");
    }

    //-----------------------------------------------
    //                  ITributacao  
    //----------------------------------------------- 
    public float calcularICMS()
    {
        return 16000.00f;
    }

    public float calcularIPI()
    {
        return 30000.00f; ;
    }
}

