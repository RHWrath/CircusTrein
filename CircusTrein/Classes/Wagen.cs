using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CircusTrein.Classes
{
    public class Wagen
    {

        public int WagenMaxCapiciteit;
        public int WagenCurrentCapiciteit;
        public bool CarnivorePresent;
        public int CarnivoreSize;
        public int SmallestHerbivoreSize;

        public Wagen()
        {
            WagenMaxCapiciteit = 10;
            WagenCurrentCapiciteit = 0;
            CarnivorePresent = false;
        }
        public bool RoomInWagon(Animal animal)
        {
            if (WagenCurrentCapiciteit + (int)animal.SizePoints < WagenMaxCapiciteit)
            {
                return true;
            }
            return false;
        }
        



    }
}
