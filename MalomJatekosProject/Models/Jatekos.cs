using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalomJatekosProject.Models
{
    public class Jatekos
    {
        public int StartingPoints { get;}
        public int Points { get; private set; }
        public string Name { get; set; }
        public Guid Id { get; } = Guid.NewGuid();

        public Jatekos(int startingPoints, string name)
        {
            if(startingPoints < 0)
            {
                throw new ArgumentException("A kezdőpontok száma nem lehet negatív!");
            }
            StartingPoints = startingPoints;
            Points = startingPoints;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} ({Id}) -> {Points} pont";
        }
    }
}
