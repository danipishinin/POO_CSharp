using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class VeiculoUsado
{
    // Atributos
    protected string modelo;
    protected int anoFab ;
    protected float valor;

    public VeiculoUsado()
    {
    }

    public VeiculoUsado(string modelo, int anoFab, float valor)
    {
        this.modelo = modelo;
        this.anoFab = anoFab;
        this.valor = valor;
    }

    // Propriedades
    public string Modelo { get => modelo; set => modelo = value; }
    public int AnoFab { get => anoFab; set => anoFab = value; }
    public float Valor { get => valor; set => valor = value; }


    // Métodos
    public virtual float calcularDepreciacao(float valor)
    {
        float resultado;
        resultado = valor - (valor * 0.10f);
        return resultado;
    }

    public virtual void imprimirDados()
    {
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano Fab: " + anoFab);
        Console.WriteLine("Valor: " + valor);
    }

}

