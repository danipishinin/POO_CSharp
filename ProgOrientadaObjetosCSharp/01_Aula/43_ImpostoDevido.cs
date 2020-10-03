using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ImpostoDevido
{
    public float calculaImposto(ITributacao o_Imposto)
    {
        float icms, ipi, impostoDevido;

        icms = o_Imposto.calcularICMS();
        ipi = o_Imposto.calcularIPI();

        impostoDevido = icms + ipi;

        return impostoDevido;
    }
}

