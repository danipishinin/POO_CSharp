using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Correios
{
    public string obterCidade(string cep)
    {
        switch (cep)
        {
            case "14000":
                return "Ribeirão Preto";

            case "14400":
                return "Franca";

            default:
                return "O CEP não foi encontrado!";
        }       
    }
}

