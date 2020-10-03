using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Matricula
{
    public int Nro;   

    public Estudante estudante;
    public Disciplina disciplina;
    
    public void imprimirDados()
    {
        Console.WriteLine("Nro Matrícula: " + Nro);    
        
        if(estudante != null)
        {
            Console.WriteLine("\t Estudante: " + estudante.nome);
        }        

        if (disciplina != null)
        {
            Console.WriteLine("\t Disciplina: " + disciplina.nome);
        }        
    }
}

