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
        public bool Lost => Points <= 0;
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

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

        public void Win(int points)
        {
            if (!Lost)
            {
                Points += points;
                Wins++;
            }
        }

        public void Lose(int points)
        {
            if (!Lost)
            {
                Points -= points;
                Losses++;
            }
            else
            {
                throw new InvalidOperationException("A játékos már vesztett!");
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Id}) -> {Points} pont";
        }
    }
}
