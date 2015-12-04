using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model.enemys.states
{
    class FlyingState : State
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
            updateAnimation(e);
        }

        public void updateAnimation(Enemy e)
        {
            ChickenObject eCasted = (ChickenObject)e;
            var duckUp = Properties.Resources.duck_up;
            var duckDown = Properties.Resources.duck_down;
            
            if (eCasted.imagePos)
            {
                if (eCasted.imageBlock >= 11)
                {
                    eCasted.btn.BackgroundImage = duckUp;
                    eCasted.imagePos = false;
                    eCasted.imageBlock = 0;
                }
                else { eCasted.imageBlock = eCasted.imageBlock + 1; }
            }
            else
            {
                if (eCasted.imageBlock >= 11)
                {
                    eCasted.btn.BackgroundImage = duckDown;
                    eCasted.imagePos = true;
                    eCasted.imageBlock = 0;
                }
                else { eCasted.imageBlock = eCasted.imageBlock + 1; }
            }
        }
    }
}
