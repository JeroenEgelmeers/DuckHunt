using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    public abstract class Level
    {
        public int currentLevel;
        public int maxChickenSpeed;
        public int chickensTogether;
        public int newChickenChance;
        public int maxChickensOnScreen;
        public int rocketAfterChicks;
        public bool endScreen;
        public bool levelCompleted;
        public System.Drawing.Bitmap backgroundImage;

        public abstract bool checkLevelCompleted(int score);

        public void gameOver()
        {
            maxChickenSpeed     = 0;
            chickensTogether    = 0;
            newChickenChance    = 0;
            maxChickensOnScreen = 0;
            rocketAfterChicks   = 0;
        }
    }
}
