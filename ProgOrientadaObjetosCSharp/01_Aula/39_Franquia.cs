using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Franquia: IManutencao, IFluxoCaixa
{
    public string local;
    public float valorRetorno;

    //-----------------------------------------------
    //                  IManutencao  
    //-----------------------------------------------   
    public void inserir() {
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
    //                  IFluxoCaixa  
    //----------------------------------------------- 
    public float calcularComissao(){
        return 100.50f;
    }

    public float calcularDespesas(){
        return 50.00f;
    }
}

