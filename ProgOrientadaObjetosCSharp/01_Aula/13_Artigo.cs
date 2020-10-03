using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Artigo
{
    public string titulo;
    public int ano;    
    private Autor[] autores;  // 0...3 ou 0...* // RELACIONAMENTO

    public Autor[] Autores {
        get{
            if (autores == null) {
                autores = new Autor[3];
            }
            return autores;
        }
        set {
            if (autores == null){
                autores = new Autor[3];
            }
            autores = value;
        }
    }

    public void imprimirDados()
    {
        int ind;

        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Ano: " + ano);

        // 0...*
        if (autores != null)
        {
            for (ind = 0; ind < 3; ind++)
            {
                if(autores[ind] != null)
                {
                    autores[ind].imprimirDados();
                }                                
            }
        }
    }
}


