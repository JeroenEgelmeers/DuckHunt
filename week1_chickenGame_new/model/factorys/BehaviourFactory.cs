using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model.factorys
{
    class BehaviourFactory
    {
        public Behaviour createMoveBehaviour(string kind)
        {
            if (kind == "chicken")
            {
                return new MoveBehaviour();
            }else if(kind == "raket") {
                return new MoveBehaviour();
            }
            else { return null; }
        }
    }
}
