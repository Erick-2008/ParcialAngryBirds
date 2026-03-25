namespace AngryBirds;
public class Terence : Pajaro
{
    private int vecesEnojado = 0;
    public int Multiplicador { get; set; } = 1;

    public override void Enojarse()
    {
        vecesEnojado++;
        base.Enojarse();
    }

    public override int Fuerza()
    {
        return Ira * vecesEnojado * Multiplicador;
    }
}