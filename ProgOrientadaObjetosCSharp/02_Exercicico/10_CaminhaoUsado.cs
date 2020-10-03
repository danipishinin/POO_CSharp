using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CaminhaoUsado : VeiculoUsado
{
    private int capacidade;
    private int nroEixos;

    public CaminhaoUsado()
    {
    }

    public CaminhaoUsado(string modelo, int anoFab, float valor, int capacidade, int nroEixos)
    {
        base.modelo = modelo;
        base.anoFab = anoFab;
        base.valor = valor;
        this.capacidade = capacidade;
        this.nroEixos = nroEixos;
    }

    public int Capacidade { get => capacidade; set => capacidade = value; }
    public int NroEixos { get => nroEixos; set => nroEixos = value; }


    public override float calcularDepreciacao(float valor)
    {
        float resultado;
        resultado = valor - (valor * 0.30f);
        return resultado;
    }

    public override void imprimirDados()
    {
        base.imprimirDados();
        Console.WriteLine("Capacidade: " + capacidade);
        Console.WriteLine("Nro eixos: " + anoFab);   
    }



}

