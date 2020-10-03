using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Criptografia
{
    public int dado;
    
    public int Dado
    {
        get
        {
            int valorDescriptografado;

            valorDescriptografado = dado / 30;

            return valorDescriptografado;
        }
        set
        {
            int valorCriptografado;

            valorCriptografado = value * 30;

            dado = valorCriptografado;
        }
    }
}

