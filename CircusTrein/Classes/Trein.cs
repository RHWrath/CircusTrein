using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Classes
{
    public class Trein
    {

        public int WagenMaxCapiciteit;
        public int AantalWagens;
        public int WagenCurrentCapiciteit;

        public Trein()
        {
            WagenMaxCapiciteit = 10;
            AantalWagens = 1;
            WagenCurrentCapiciteit = 0;
        }
    }
}
