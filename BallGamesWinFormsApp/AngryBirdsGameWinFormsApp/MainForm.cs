using Timer = System.Windows.Forms.Timer;

namespace AngryBirdsGameWinFormsApp
{
    public partial class MainForm : Form
    {
        private BirdsBall birdsBall;
        private PigBall pigBall;
        private int score = 0;
        public Random random = new Random();

        Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            birdsBall = new BirdsBall(this);
            birdsBall.Start();

            pigBall = new PigBall(this);
            pigBall.Start();

            timer.Interval = 16;
            timer.Tick += GameLoop;
            timer.Start();

        }

        private void GameLoop(object sender, EventArgs e)
        {
            if ((birdsBall.centerX - pigBall.centerX) * (birdsBall.centerX - pigBall.centerX) +
                (birdsBall.centerY - pigBall.centerY) * (birdsBall.centerY - pigBall.centerY) <
                (birdsBall.radius + pigBall.radius) * (birdsBall.radius + pigBall.radius))
            {             
                score++;
                scoreLabel.Text = "Очки: " + score;

                birdsBall.centerX = 30;
                birdsBall.centerY = this.ClientSize.Height - birdsBall.radius - 10;
                birdsBall.vx = 0;
                birdsBall.vy = 0;

                pigBall.centerX = random.Next(pigBall.radius, this.ClientSize.Width - pigBall.radius);
                pigBall.centerY = random.Next(pigBall.radius, this.ClientSize.Height - pigBall.radius);
            }

            this.Invalidate();
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            birdsBall.Draw(e.Graphics);
            pigBall.DrawPig(e.Graphics);
        }
       
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (birdsBall.centerX == 30 && birdsBall.centerY == this.ClientSize.Height - birdsBall.radius - 10 && birdsBall.vx == 0 && birdsBall.vy == 0)
            {
                float dx = e.X - birdsBall.centerX;
                float dy = e.Y - birdsBall.centerY;
                birdsBall.Shoot(dx / 10, dy / 10);
            }
        }
       
    }

}

