using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Carpete
{   
    private float comprimento;
    private float largura;
    private float area;

    public Carpete()
    {
        comprimento = 2;
        largura = 2;
        calcArea();
    }
    public Carpete(float comprimento)
    {
        this.comprimento = comprimento;
        this.largura = 2;
        calcArea();
    }
    public Carpete(float comprimento, float largura)
    {
        this.comprimento = comprimento;
        this.largura = largura;
        calcArea();
    }

    public float Comprimento
    {
        get{
            return comprimento;
        }
        set{
            comprimento = value;
            calcArea();
        }
    }
    public float Largura
    {
        get {
            return largura;
        }
        set{
            largura = value;
            calcArea();
        }
    }
    public float Area
    {
        get{
            return area;
        }
    }

    private void calcArea()
    {
        area = comprimento * largura;
    }

    public void encomendarCarpete(float comprimento, float largura)
    {
        this.comprimento = comprimento;
        this.largura = largura;
        calcArea(); 
    }

    public void encomendarCarpete(int comprimento, int largura)
    {
        this.comprimento = (float) comprimento;
        this.largura = (float) largura;
        calcArea();
    }
}




