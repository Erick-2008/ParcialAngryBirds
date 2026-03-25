namespace AngryBirds;
public class InvasionCerditos : IEvento
{
    public int Cantidad { get; set; }

    public void Aplicar(IslaPajaro isla)
    {
        int veces = Cantidad / 100;

        foreach (var p in isla.Pajaros)
        {
            for (int i = 0; i < veces; i++)
                p.Enojarse();
        }
    }
}