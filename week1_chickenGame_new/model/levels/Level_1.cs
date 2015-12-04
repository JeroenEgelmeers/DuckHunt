using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    class Level_1 : Level
    {
        public Level_1()
        {
            currentLevel        = 1;
            maxChickenSpeed     = 20;
            chickensTogether    = 1;
            newChickenChance    = 80;
            maxChickensOnScreen = 10;
            rocketAfterChicks   = 0;
            endScreen = false;
            backgroundImage = Properties.Resources.level4Bg;
        }

        public override bool checkLevelCompleted(int score)
        {
            if (score > 10) { return true; }else { return false; }
        }
    }
}
