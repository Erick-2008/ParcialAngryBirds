namespace AngryBirds;
public class SerieEventos : IEvento
{
    public List<IEvento> Eventos { get; set; } = new();

    public void Aplicar(IslaPajaro isla)
    {
        foreach (var e in Eventos)
        {
            e.Aplicar(isla);
        }
    }
}