namespace AngryBirds;
public class Chuck : Pajaro
{
    public int Velocidad { get; private set; }

    public Chuck(int velocidad)
    {
        Velocidad = velocidad;
    }

    public override void Enojarse()
    {
        Velocidad *= 2;
    }

    public override void Tranquilizar()
    {
        // no hace nada
    }

    public override int Fuerza()
    {
        if (Velocidad <= 80)
            return 150;

        return 150 + (Velocidad - 80) * 5;
    }
}