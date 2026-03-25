namespace AngryBirds;
public class SesionIra : IEvento
{
    public void Aplicar(IslaPajaro isla)
    {
        foreach (var p in isla.Pajaros)
        {
            if (p is not Chuck)
                p.Tranquilizar();
        }
    }
}