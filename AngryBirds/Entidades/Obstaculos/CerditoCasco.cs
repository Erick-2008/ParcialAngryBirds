using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryBirds;
public class CerditoCasco : IObstaculo
{
    public int ResistenciaCasco { get; set; }

    public int Resistencia()
    {
        return 10 * ResistenciaCasco;
    }
}