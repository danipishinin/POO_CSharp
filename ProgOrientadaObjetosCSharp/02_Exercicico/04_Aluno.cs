using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Aluno
{
    private int codAluno;
    private string nome;
    private float notaP1;
    private float notaP2;

    public int CodAluno {
        get
        {
            return codAluno;
        }
        set
        {
            if (value <= 0 )
            {
                throw new Exception("Por favor, informe um código válido!");
            }
            else
            {
                codAluno = value;
            }
        }
    }
    public string Nome {
        get
        {
            return nome;
        }
        set
        {
            if (String.IsNullOrEmpty(value)) {
                throw new Exception("Por favor, informe o nome do aluno!");
            }
            else
            {
                nome = value;
            }                 
        }       
    }
    public float NotaP1 {
        get
        {
            return notaP1;
        }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new Exception("Por favor, informe uma nota válida para P1!");
            }
            else
            {
                notaP1 = value;
            }           
        }
    }
    public float NotaP2 {
        get
        {
            return notaP2;
        }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new Exception("Por favor, informe uma nota válida para P2!");
            }
            else
            {
                notaP2 = value;
            }            
        }
    }
}

