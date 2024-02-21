using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Wagen
    {

        public int WagenMaxCapiciteit;
        public int AantalWagens;
        public int WagenCurrentCapiciteit;

        public Wagen()
        {
            WagenMaxCapiciteit = 10;
            AantalWagens = 0;
            WagenCurrentCapiciteit = 0;
        }
    }
}
