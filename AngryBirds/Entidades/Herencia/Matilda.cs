namespace AngryBirds;
public class Matilda : Pajaro
{
    public List<Huevo> Huevos { get; set; } = new();

    public override void Enojarse()
    {
        base.Enojarse();
        Huevos.Add(new Huevo { Peso = 2 });
    }

    public override int Fuerza()
    {
        return Ira * 2 + Huevos.Sum(h => h.Fuerza());
    }
}