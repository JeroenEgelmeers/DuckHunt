using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    class LevelFactory
    {
        private GameModel cl_model;
        public Level currentLevel;

        public List<Level> levels;
        public int level;
             
        public LevelFactory(GameModel model)
        {
            cl_model = model;
            levels = new List<Level>();

            // Level map..
            levels.Add(new Level_1());
            levels.Add(new Level_2());
            levels.Add(new Level_3());
            levels.Add(new Level_4());
            levels.Add(new Level_finish(cl_model));
        }

        public void updateLevel()
        {
            if (currentLevel.checkLevelCompleted(cl_model.playerScore))
            {
                nextLevel();
            }
        }

        public void nextLevel()
        {
            currentLevel = levels[level];
            level++;
        }

        public void startGame()
        {
            level = 1;
            currentLevel = levels.First();
        }
    }
}
