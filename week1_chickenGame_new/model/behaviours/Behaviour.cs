using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    abstract class Behaviour
    {
        public Enemy enemy;

        public abstract void setEnemy(Enemy e);
    }
}
