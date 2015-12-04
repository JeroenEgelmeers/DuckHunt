using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using week1_chickenGame_new.controller;
using week1_chickenGame_new.model;
using week1_chickenGame_new.model.enemys.states;
using week1_chickenGame_new.model.factorys;

namespace week1_chickenGame_new
{
    public partial class Form1 : Form
    {
        public GameModel cl_model;
        private ChickenFactory factory;
        private LevelFactory levelFactory;
        private BehaviourFactory bf;
        private MoveContainer mc;
        private List<Enemy> chickens;
        private Thread gameThread;
        private Random randomNumber;

        public Form1()
        {
            // Setup model
            cl_model = new GameModel(100, 100, 0, 3, false);
            levelFactory = new LevelFactory(cl_model);
            chickens = new List<Enemy>();
            randomNumber = new Random();
            mc = new MoveContainer();
            bf = new BehaviourFactory();
            factory = new ChickenFactory(cl_model, levelFactory, mc, bf);
            this.DoubleBuffered = true;
            levelFactory.startGame();

            cl_model.playerLifes = 3;
            cl_model.playerScore = 0;

            // Start game thread
            gameThread = new Thread(() =>
            {
                update();
            });
            gameThread.Start();

            // Show view
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_PlayerLifes.Text = "Levens: " + cl_model.playerLifes;
            label_PlayerScore.Text = "Score: " + cl_model.playerScore;
        }

        private void update()
        {
            while (gameThread.IsAlive)
            {
                // Draw chickens to right position
                while (cl_model.gameOn && !cl_model._gameWait || chickens.Count > 0 && !cl_model._gameWait)
                {
                    // Add new chicken?
                    if (chickens.Count < levelFactory.currentLevel.maxChickensOnScreen)
                    {
                        Random random = new Random();
                        if (random.Next(0, levelFactory.currentLevel.newChickenChance) == 1)
                        {
                            int addChickens = random.Next(1, levelFactory.currentLevel.chickensTogether);
                            for (int i = 1; i <= addChickens; i++)
                            {
                                addChicken();
                            }
                        }
                    }
                    // Remove chickens?
                    List<Enemy> stack = new List<Enemy>();
                    stack.AddRange(chickens);

                    foreach(Enemy e in stack)
                    {
                        if (e.state is DeadState || e.state is EscapedState)
                        {
                            chickens.Remove(e);
                        }
                    }

                    // Update chicken position
                    mc.move();

                    rePaint();
                    levelUpdater();

                    Thread.Sleep(16);
                }
            }
        }

        public void reDrawObject(Button btn)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => reDrawObject(btn)));
                return;
            }

            this.Controls.Remove(btn);
        }

        public void levelUpdater()
        {
            if (levelFactory.currentLevel.checkLevelCompleted(cl_model.playerScore))
            {
                levelFactory.updateLevel();
            }
        }

        private void rePaint()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => rePaint()));
                return;
            }

            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //UpdateStyles();

            // Update enemys
            foreach (Enemy c in chickens)
            {
                c.btn.Location  = new Point(c.ball_x, c.ball_y);
                c.btn.Size      = new Size(c.ballSize_x, c.ballSize_y);
            }

            if (chickens.Count <= 0 && levelFactory.currentLevel.endScreen)
            {
                youWon.Image = week1_chickenGame_new.Properties.Resources.youwon;
                youWon.Visible = true; // Game WIN screen
            }

            if (cl_model.playerLifes <= 0) {
                cl_model.gameOn = false;
                youWon.Image = week1_chickenGame_new.Properties.Resources.gameOver;
                youWon.Visible = true; // Game LOSE screen
                levelFactory.currentLevel.gameOver();
            }

            if (levelFactory.currentLevel.backgroundImage != null)
            {
                this.BackgroundImage = levelFactory.currentLevel.backgroundImage;
            }

            levellabel.Text = "Level: " + levelFactory.level;
            label_PlayerLifes.Text = "Levens: " + cl_model.playerLifes;
            label_PlayerScore.Text = "Score: " + cl_model.playerScore;
        }


        // Layout and buttons
        private void addChicken()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => addChicken()));
                return;
            }

            Enemy c;

            if (randomNumber.Next(0,levelFactory.currentLevel.rocketAfterChicks) == 1)
            {
                c = factory.create("raket", levelFactory.level, this);
            }else
            {
                c = factory.create("chicken", levelFactory.level, this);
            }
            chickens.Add(c);
        }



        /// <summary>
        /// VIEW IMPLEMENTATION
        /// </summary>
        private void button_StartGame(object sender, EventArgs e)
        {
            if (!cl_model.gameOn)
            {
                cl_model.gameOn = true;
                startButton.Text = "Stop spel";
            }
            else
            {
                if (!cl_model._gameWait)
                {
                    // stop game
                    cl_model._gameWait = true;
                    startButton.Text = "Start spel";
                }
                else
                {
                    // start game
                    cl_model._gameWait = false;
                    startButton.Text = "Stop spel";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameThread.Abort();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        public void enemyClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Enemy c = (Enemy)((Button)sender).Tag;
            c.killed();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
