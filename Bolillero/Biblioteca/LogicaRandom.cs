using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class LogicaRandom : ILogica
    {
        public List<Bolilla> SacarBolillas(Bolillero bolillero, int cantidadBolillasASacarEnLaJugada)
        {
            int bolillaNumeroMayor = bolillero.Bolillas.Max(bolilla => bolilla.numeroBolilla);
            List<Bolilla> BolillasSacadas = new();
            Random rnd = new();
            for(int i = 1; i <= cantidadBolillasASacarEnLaJugada; i++){
                Bolilla bolillaSacada = new Bolilla(rnd.Next(0, bolillaNumeroMayor));
                while(BolillasSacadas.Any(bolilla => bolilla.numeroBolilla == bolillaSacada.numeroBolilla)){
                    bolillaSacada = new Bolilla(rnd.Next(0, bolillaNumeroMayor));
                }
                BolillasSacadas.Add(bolillaSacada);
            }

            return BolillasSacadas;
        }
    }
}