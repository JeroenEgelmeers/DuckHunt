using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    class Level_4 : Level
    {
        public Level_4()
        {
            currentLevel = 4;
            maxChickenSpeed = 30;
            chickensTogether = 5;
            newChickenChance = 60;
            maxChickensOnScreen = 30;
            rocketAfterChicks = 12;
            endScreen = false;
            backgroundImage = Properties.Resources.level4Bg;
        }

        public override bool checkLevelCompleted(int score)
        {
            if (score > 60) { return true; } else { return false; }
        }
    }
}
