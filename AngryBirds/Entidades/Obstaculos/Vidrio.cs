namespace AngryBirds;
public class Vidrio : IObstaculo
{
    public int Ancho { get; set; }
    public int Resistencia() => 10 * Ancho;
}