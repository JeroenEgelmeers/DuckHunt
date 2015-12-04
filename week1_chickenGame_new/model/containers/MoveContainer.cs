using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    class MoveContainer
    {
        private List<Behaviour> behaviours = new List<Behaviour>();
        private List<Behaviour> removedBehaviour = new List<Behaviour>();

        public void addBehaviour(Behaviour b) { behaviours.Add(b); }
        public void removeBehaviour(Behaviour b) { removedBehaviour.Add(b); }

        public void move()
        {
            foreach(Behaviour b in removedBehaviour)
            {
                behaviours.Remove(b);
            }

            foreach (MoveBehaviour b in behaviours)
            {
                b.move();
            }
        }

    }
}