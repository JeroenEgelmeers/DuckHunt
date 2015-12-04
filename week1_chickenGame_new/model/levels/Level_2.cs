using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    class Level_2 : Level
    {
        public Level_2()
        {
            currentLevel = 2;
            maxChickenSpeed = 30;
            chickensTogether = 2;
            newChickenChance = 70;
            maxChickensOnScreen = 20;
            rocketAfterChicks  = 20;
            endScreen = false;
        }

        public override bool checkLevelCompleted(int score)
        {
            if (score > 20) { return true; } else { return false; }
        }
    }
}
