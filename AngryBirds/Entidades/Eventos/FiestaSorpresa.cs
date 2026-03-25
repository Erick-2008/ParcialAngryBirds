namespace AngryBirds;
public class FiestaSorpresa : IEvento
{
    public List<Pajaro> Homenajeados { get; set; } = new();

    public void Aplicar(IslaPajaro isla)
    {
        foreach (var p in Homenajeados)
        {
            p.Enojarse();
        }
    }
}