using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoMunicipal
{
    public class CalcularImposto
    {
        public void calcularVlrImposto()
        {
            Console.WriteLine("Imposto Municipal: R$ 50,00");
        }
    }
}

namespace ImpostoFederal
{
    public class CalcularImposto
    {
        public void calcularVlrImposto()
        {
            Console.WriteLine("Imposto Federal: R$ 200,00");
        }
    }
}


namespace ImpostoRenda
{
    public class CalcularIR
    {
        public void calcularVlrImposto()
        {
            Console.WriteLine("Imposto IR: R$ 1000,00");
        }
    }
}
