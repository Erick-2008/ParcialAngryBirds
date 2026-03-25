namespace AngryBirds;
public class Madera : IObstaculo
{
    public int Ancho { get; set; }
    public int Resistencia() => 25 * Ancho;
}