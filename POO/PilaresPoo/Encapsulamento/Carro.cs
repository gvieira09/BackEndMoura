

namespace Encapsulamento;


class Carro
{
    public string Marca;
    public string Modelo;
    public int VelocidadeAtual;

    public void DefinirMarca(string valor)
    {
        Marca = valor;
    }

    public string ObterMarca()
    {
        return Marca;
    }

    public void DefinirModelo(string valor)
    {
        Modelo = valor;
    }

    public string ObterModelo()
    {
        return Modelo;
    }

 
    public int ObterVelocidade()
    {
        return VelocidadeAtual;
    }

    public void Acelerar(int valor)
    {
        if (valor > 0)
        {
            VelocidadeAtual += valor;
        }
    }

    public void Frear(int valor)
    {
        if (valor > 0)
        {
            VelocidadeAtual -= valor;
            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }
    }
}

