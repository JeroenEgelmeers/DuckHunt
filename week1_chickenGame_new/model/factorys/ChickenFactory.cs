using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week1_chickenGame_new.model.factorys;

namespace week1_chickenGame_new.model
{
    class ChickenFactory
    {
        private Random randomNumber;
        private GameModel cl_model;
        private LevelFactory levelFactory;
        private MoveContainer mc;
        private BehaviourFactory bf;

        public ChickenFactory(GameModel model, LevelFactory setLevelFactory, MoveContainer setMc, BehaviourFactory setBf)
        {
            randomNumber = new Random();
            cl_model = model;
            levelFactory = setLevelFactory;
            mc = setMc;
            bf = setBf;
        }

        public Enemy create(string kind, int level, Form1 form)
        {
            // REQUIRMENT TODO: Should have no IF / ELSE
            if (kind.Equals("chicken"))
            {
                return new ChickenObject(0, randomNumber.Next(70, 300), randomNumber.Next(4, levelFactory.currentLevel.maxChickenSpeed), 62, 56, mc, bf, form);
            }
            else if (kind.Equals("raket"))
            {
                return new Raket(0, randomNumber.Next(70, 300), randomNumber.Next(4, levelFactory.currentLevel.maxChickenSpeed), 62, 56, mc, bf, form);
            }
            else
            {
                // Return null
                return null;
            }
        }
    }
}
