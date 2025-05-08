
namespace Biblioteca;

public class LogicaPrimero : ILogica
{
    public List<Bolilla> SacarBolillas(Bolillero bolillero, int cantidadBolillasASacarEnLaJugada)
    {
        List<Bolilla> BolillasSacadas = bolillero.Bolillas.Select(Bolilla => Bolilla).Take(cantidadBolillasASacarEnLaJugada).ToList();

        return BolillasSacadas;
    }
}