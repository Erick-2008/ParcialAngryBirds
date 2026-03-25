namespace AngryBirds;
public abstract class Pajaro
{
    public int Ira { get; protected set; }

    public virtual void Enojarse()
    {
        Ira *= 2;
    }

    public virtual void Tranquilizar()
    {
        Ira = Math.Max(0, Ira - 5);
    }

    public abstract int Fuerza();
}