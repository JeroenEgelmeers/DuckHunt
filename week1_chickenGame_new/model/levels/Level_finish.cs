using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    class Level_finish : Level
    {
        private GameModel cl_model;
        public Level_finish(GameModel model)
        {
            currentLevel = 4;
            maxChickenSpeed = 0;
            chickensTogether = 0;
            newChickenChance = 0;
            maxChickensOnScreen = 0;
            rocketAfterChicks = 0;
            endScreen = true;
            cl_model = model;
        }

        public override bool checkLevelCompleted(int score)
        {
            
            endGame();
            return false;
        }

        public void endGame()
        {
            cl_model.gameOn = false;
        }
    }
}
