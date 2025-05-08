using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca;

public class Bolillero
{
    public List<Bolilla> Bolillas {get;set;} = new List<Bolilla>();

    public ILogica logica { get; init; }

    public Bolillero(int cantidadBolillasBolillero, ILogica logica)
    {
        this.logica = logica;
        GenerarBolillas(cantidadBolillasBolillero);
    }

    public void GenerarBolillas(int cantidadBolillas)
    {
        Bolillas.Clear();
        for(int i = 0; i < cantidadBolillas; i++)
        {
            Bolilla bolilla = new Bolilla(i);
            Bolillas.Add(bolilla);
        }
    }

    public List<Bolilla> SacarBolillas(int cantidadBolillasASacarEnLaJugada)
    {
        List<Bolilla> bolillasSacadas = logica.SacarBolillas(this, cantidadBolillasASacarEnLaJugada);

        Bolillas = Bolillas.Except(bolillasSacadas).ToList();

        return bolillasSacadas;
    }

    public bool CompararRespuesta(List<Bolilla> bolillasSacadas, List<Bolilla> jugada)
    {
        bool resultado = true;
        if(!bolillasSacadas.SequenceEqual(jugada)){
            return false;
        }
        return resultado;
    }

    public bool Jugar(List<int> jugada)
    {
        List<Bolilla> bolillas = new List<Bolilla>();
        foreach(int numero in jugada)
        {
            bolillas.Add(new Bolilla(numero));
        }
        var lista = SacarBolillas(jugada.Count());
        bool resultado = CompararRespuesta(lista, bolillas);
        return resultado;
    }
}
