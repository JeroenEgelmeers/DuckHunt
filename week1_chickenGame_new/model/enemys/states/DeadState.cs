using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model.enemys.states
{
    class DeadState : State
    {
        public override void update(Enemy e, int dt)
        {
            // Do nothing because you're dead!
        }
    }
}
