using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model.enemys.states
{
    abstract class State
    {
        public abstract void update(Enemy e, int dt); 
    }
}
