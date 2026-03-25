namespace AngryBirds;
public class Bomb : Pajaro
{
    public int Tope { get; set; } = 9000;

    public override int Fuerza()
    {
        return Math.Min(Ira * 2, Tope);
    }
}