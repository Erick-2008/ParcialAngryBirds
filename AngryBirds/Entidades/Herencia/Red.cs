namespace AngryBirds;
public class Red : Pajaro
{
    private int vecesEnojado = 0;

    public override void Enojarse()
    {
        vecesEnojado++;
        base.Enojarse();
    }

    public override int Fuerza()
    {
        return Ira * 10 * vecesEnojado;
    }
}