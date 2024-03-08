using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Train
    {

        public int AantalWagens;
        public List<Wagen> wagons;

        public Train()
        {
            AantalWagens = 0;
            wagons = new();
        }

        public void CreateWagon(Animal animal)
        {

            Wagen wagon = new Wagen();
            wagon.WagenCurrentCapiciteit = (int)animal.SizePoints;

            if ((int)animal.Diet == 1)
            {
                wagon.CarnivorePresent = true;
                wagon.CarnivoreSize = (int)animal.SizePoints;
            }
            else
            {
                wagon.SmallestHerbivoreSize = (int)animal.SizePoints;
            }
            wagons.Add(wagon);

            AantalWagens++;
        }
    }
}
