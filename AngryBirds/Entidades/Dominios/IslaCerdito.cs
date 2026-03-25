namespace AngryBirds;
public class IslaCerdito
{
    public List<IObstaculo> Obstaculos { get; set; } = new();

    public void RecibirAtaque(Pajaro pajaro)
    {
        if (!Obstaculos.Any()) return;

        var obstaculo = Obstaculos.First();

        if (pajaro.Fuerza() > obstaculo.Resistencia())
        {
            Obstaculos.RemoveAt(0);
        }
    }

    public bool QuedoLibre()
    {
        return !Obstaculos.Any();
    }
}