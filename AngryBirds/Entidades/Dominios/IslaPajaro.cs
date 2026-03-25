namespace AngryBirds;
public class IslaPajaro
{
    public List<Pajaro> Pajaros { get; set; } = new();

    public List<Pajaro> PajarosFuertes()
    {
        return Pajaros.Where(p => p.Fuerza() > 50).ToList();
    }

    public int FuerzaTotal()
    {
        return PajarosFuertes().Sum(p => p.Fuerza());
    }

    public void OcurrirEvento(IEvento evento)
    {
        evento.Aplicar(this);
    }

    public void Atacar(IslaCerdito isla)
    {
        foreach (var pajaro in Pajaros)
        {
            isla.RecibirAtaque(pajaro);
        }
    }
}