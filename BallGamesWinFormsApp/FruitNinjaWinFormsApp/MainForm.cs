
using Timer = System.Windows.Forms.Timer;

namespace FruitNinjaWinFormsApp
{
    public partial class MainForm : Form
    {
        public static Random random = new Random();

        private static Timer timer = new Timer();
        private List<FruitBall> fruitBalls = new List<FruitBall>();       
        private int slowDuration = 3000;
        private float speedMultiplier = 1f;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 900;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            FruitBall fruit;

            if (random.Next(6) == 0)
            {
                var bomb = new BombBall(this);
                fruitBalls.Add(bomb);
                bomb.Start();
                return;
               
            }
            if (random.Next(10) == 0)
            {
                fruit = new BananaBall(this);
            }
            else
            {
                fruit = new FruitBall(this);
            }

            fruit.vx *= speedMultiplier;
            fruit.vy *= speedMultiplier;

            fruitBalls.Add(fruit);
            fruit.Start();
           
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = fruitBalls.Count - 1; i >= 0; i--)
            {
                var fruit = fruitBalls[i];

                if (fruit.IsHit(e.X, e.Y))
                {               
                    fruit.Stop();
                    fruit.Clear();
                    fruitBalls.Remove(fruit);

                    if (fruit is BananaBall)
                    {
                        HandleBananaHit();
                    }
                    if (fruit is BombBall)
                    {   
                        timer.Stop();                      
                        MessageBox.Show("Бомба! Игра окончена!");
                        Close();
                    }
                }
            }         
           
        }

        private void HandleBananaHit()
        {
            if (speedMultiplier == 1f) 
            {
                speedMultiplier = 0.5f;

                foreach (var f in fruitBalls)
                {
                    f.vx *= speedMultiplier;
                    f.vy *= speedMultiplier;
                }
             
                var restoreTimer = new Timer();
                restoreTimer.Interval = slowDuration;
                restoreTimer.Tick += (s, ev) =>
                {
                    speedMultiplier = 1f;

                    foreach (var f in fruitBalls)
                    {
                        f.vx *= 2f; 
                        f.vy *= 2f;
                    }

                    restoreTimer.Stop();
                };

                restoreTimer.Start();
            }
        }

    }
}
