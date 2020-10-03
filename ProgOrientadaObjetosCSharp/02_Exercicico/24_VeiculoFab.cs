using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VeiculoFab: IManutencao, ITributacao
{
    public string modelo;
    public int anoFab;

    //-----------------------------------------------
    //                  IManutencao  
    //-----------------------------------------------   
    public void inserir(){
        Console.WriteLine("Inserido com sucesso!");
    }

    public void alterar(){
        Console.WriteLine("Alterado com sucesso!");
    }

    public void pesquisar(){
        Console.WriteLine("Pesquisado com sucesso!");
    }

    public void excluir(){
        Console.WriteLine("Excluido com sucesso!");
    }

    //-----------------------------------------------
    //                  ITributacao  
    //-----------------------------------------------
    public float calcularICMS()
    {
        return 4500.50f;
    }

    public float calcularIPI()
    {
        return 9700.85f; ;
    }

}

