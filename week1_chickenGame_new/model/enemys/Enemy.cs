using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week1_chickenGame_new.model.enemys.states;

namespace week1_chickenGame_new.model
{
    abstract class Enemy
    {
        private int _ball_x, _ball_y, _ballSize_x, _ballSize_y, _ballSpeed;
        public Behaviour behaviour;
        public MoveContainer mc;
        public State state;
        public Button btn;
        private bool active;

        // Vars voor frametimer
        public static int FramesPerSecond = 10;
        public int _timePerFrame = (1000 / FramesPerSecond), nextUpdate = Environment.TickCount;

        public int ball_x { get { return this._ball_x; } set { _ball_x = value; } }
        public int ball_y { get { return this._ball_y; } set { _ball_y = value; } }
        public int ballSize_x { get { return this._ballSize_x; } set { _ballSize_x = value; } }
        public int ballSize_y { get { return this._ballSize_y; } set { _ballSize_y = value; } }
        public int ballSpeed { get { return this._ballSpeed; } set { _ballSpeed = value; } }
        public bool activeState { get { return this.active; } set { active = value; } }

        public abstract void update();
        public abstract void killed();
        public abstract void escaped();
    }
}
