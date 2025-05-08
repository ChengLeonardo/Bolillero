using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Biblioteca;
namespace TestUnitario;

public class BolilleroXUnit
{
    ILogica logicaTest = new LogicaPrimero();
    Bolillero bolillero;

    public BolilleroXUnit() => bolillero  = new Bolillero(10, logicaTest);

    [Fact]
    public void VerificarCantidadBolilleroAlCrearBolillero()
    {
        Assert.Equal(10, bolillero.Bolillas.Count());
    }

    [Fact]
    public void SacarBolilla()
    {
        List<int> bolilla = new List<int>(){0};
        Assert.True(bolillero.Jugar(bolilla));
        Assert.True(bolillero.Bolillas.Count() == 9);
        //no tengo un lugar donde simule afuera del bolillero, no se si es necesario y no lo dice en el texto,entonces no lo hice
    }
    [Fact]
    public void ReingresarBolilla()
    {
        List<int> bolilla = new List<int>(){0};
        Assert.True(bolillero.Jugar(bolilla));
        Assert.True(bolillero.Bolillas.Count() == 9);
        bolillero.GenerarBolillas(10);
        Assert.Equal(10, bolillero.Bolillas.Count());
    }

    [Fact]
    public void JugarGana(){
        List<int> jugada = new List<int>{0, 1, 2, 3, 4};
        Assert.True(bolillero.Jugar(jugada));
    }

    [Fact]
    public void JugarPierde(){
        List<int> jugada = new List<int>{4, 2, 1};
        Assert.False(bolillero.Jugar(jugada));
    }
    [Fact]
    public void GanarNVeces()
    {
        List<int> jugada = new List<int> {0, 1};

        Assert.True(bolillero.Jugar(jugada));

        //no estoy seguro si es lo que se pide hacer. 
    } 
}