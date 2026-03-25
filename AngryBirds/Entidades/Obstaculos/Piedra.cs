namespace AngryBirds;
public class Piedra : IObstaculo
{
    public int Ancho { get; set; }
    public int Resistencia() => 50 * Ancho;
}