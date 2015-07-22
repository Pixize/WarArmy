using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarArmy.Class
{
    class Unit
    {
        String name;
        int life;
        int atk;
        int def;

        //Constructor
        public Unit(string name, int life, int atk, int def)
        {
            this.name = name;
            this.life = life;
            this.atk = atk;
            this.def = def;
        }
    }
}
