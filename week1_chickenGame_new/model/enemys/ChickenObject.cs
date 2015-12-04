using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week1_chickenGame_new.model.enemys.states;
using week1_chickenGame_new.model.factorys;

namespace week1_chickenGame_new.model
{
    class ChickenObject : Enemy
    {
        // Vars
        private int blockImage;
        public bool imageUp;
        public Form1 form;

        // Constructors
        public ChickenObject(int setBall_x, int setBall_y, int setBallSpeed, int setBallSize_x, int setBallSize_y, MoveContainer setMc, BehaviourFactory setBf, Form1 setForm)
        {
            // Set ints by setters
            ball_x     = setBall_x;
            ball_y     = setBall_y;
            ballSpeed  = setBallSpeed;
            ballSize_x  = setBallSize_x;
            ballSize_y  = setBallSize_y;
            activeState = true;
            behaviour = (setBf.createMoveBehaviour("chicken"));
            mc = setMc;
            mc.addBehaviour(behaviour);
            behaviour.setEnemy(this);
            state = new FlyingState();
            form = setForm;
            createButton();
        }

        // Getters & Setters
        public bool imagePos { get { return this.imageUp; }set { imageUp = value; } }
        public int imageBlock { get { return this.blockImage; } set { blockImage = value; } }

        public void flyUp(bool up) {
            if (up) { btn.BackgroundImage = Properties.Resources.duck_up; }
            else { btn.BackgroundImage = Properties.Resources.duck_down; }
        }

        private void createButton()
        {
            btn = new System.Windows.Forms.Button();
            btn.Tag = this;
            btn.Text = "";
            btn.BackColor = Color.Transparent;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.BackgroundImage = Properties.Resources.duck_up;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = new Point(ball_x, ball_y);
            btn.Size = new Size(ballSize_x, ballSize_y);
            btn.Click += new EventHandler(form.enemyClicked);
            form.Controls.Add(btn);
        }

        // update functie voor positions
        public override void update()
        {
            state.update(this, nextUpdate);
        }

        public override void escaped()
        {
            state = new EscapedState();
            form.reDrawObject(btn);
            mc.removeBehaviour(behaviour);
            form.cl_model.playerLifes--;

        }

        public override void killed()
        {
            state = new DeadState();
            form.reDrawObject(btn);
            mc.removeBehaviour(behaviour);
            form.cl_model.playerScore++;
        }
    }
}
