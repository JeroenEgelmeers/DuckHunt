using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    class Level_3 : Level
    {
        public Level_3()
        {
            currentLevel = 3;
            maxChickenSpeed = 30;
            chickensTogether = 4;
            newChickenChance = 60;
            maxChickensOnScreen = 30;
            rocketAfterChicks = 15;
            endScreen = false;
            backgroundImage = Properties.Resources.level3Bg;
        }

        public override bool checkLevelCompleted(int score)
        {
            if (score > 40) { return true; } else { return false; }
        }
    }
}
