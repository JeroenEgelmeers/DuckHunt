using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    class MoveBehaviour : Behaviour
    {

        public void move()
        {
            enemy.update();
        }

        public override void setEnemy(Enemy e)
        {
            enemy = e;
        }
    }
}
