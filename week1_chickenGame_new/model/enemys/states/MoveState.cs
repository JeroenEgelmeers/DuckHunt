using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model.enemys.states
{
    class MoveState : State
    {
        public override void update(Enemy e, int nextUpdate)
        {
            if (Environment.TickCount > nextUpdate)
            {
                e.nextUpdate = Environment.TickCount + e._timePerFrame;

                // update bal position
                e.ball_x += e.ballSpeed;
                if (e.ball_x >= 500) { e.escaped(); }
            }
        }
    }
}
