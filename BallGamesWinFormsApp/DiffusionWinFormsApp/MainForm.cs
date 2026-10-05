using BallCommon;

namespace DiffusionWinFormsApp
{
    public partial class MainForm : Form
    {       
        private List<RandomMoveBall> moveBalls;

        private int leftBlueHits = 0;
        private int rightBlueHits = 0;
        private int topBlueHits = 0;
        private int downBlueHits = 0;

        private int leftPinkHits = 0;
        private int rightPinkHits = 0;
        private int topPinkHits = 0;
        private int downPinkHits = 0;      

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            moveBalls = new List<RandomMoveBall>();

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new BallBorders(this, Color.SkyBlue);                
                moveBall.OnHited += MoveBall_OnHited;
                moveBalls.Add(moveBall);         
                moveBall.Start();
            }

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new BallBorders(this, Color.LightPink);               
                moveBall.OnHited += MoveBall_OnHited;
                moveBalls.Add(moveBall);               
                moveBall.Start();
            }
        }

        private void MoveBall_OnHited(object? sender, HitEventArgs e)
        {
            var ball = (BallBorders)sender;          

            if (ball.color == Color.SkyBlue)
            {
                switch (e.side)
                {
                    case Side.Left: leftBlueHits++; leftBlueLabel.Text = leftBlueHits.ToString();break;
                    case Side.Right: rightBlueHits++; rightBlueLabel.Text = rightBlueHits.ToString();break;
                    case Side.Top:topBlueHits++; topBlueLabel.Text = topBlueHits.ToString();break;
                    case Side.Down:downBlueHits++; downBlueLabel.Text = downBlueHits.ToString();break;
                }
            }
            else if (ball.color == Color.LightPink)
            {
                switch (e.side)
                {
                    case Side.Left:leftPinkHits++; leftPinkLabel.Text = leftPinkHits.ToString();break;
                    case Side.Right:rightPinkHits++; rightPinkLabel.Text = rightPinkHits.ToString();break;
                    case Side.Top:topPinkHits++;topPinkLabel.Text = topPinkHits.ToString();break;
                    case Side.Down:downPinkHits++;downPinkLabel.Text = downPinkHits.ToString();break;
                }
            }

            CheckSplit();
            UpdatePercentLabel();
        }

        private void CheckSplit()
        {
            int blueLeft = 0;
            int blueRight = 0;
            int pinkLeft = 0;
            int pinkRight = 0;

            int halfX = this.ClientSize.Width / 2;

            foreach (var ball in moveBalls)
            {
                bool isLeft = ball.centerX < halfX;

                if (ball.color == Color.SkyBlue)
                {
                    if (isLeft)
                    {
                        blueLeft++;
                    }
                    else
                    {
                        blueRight++;
                    }
                }
                else if (ball.color == Color.LightPink)
                {
                    if (isLeft)
                    {
                        pinkLeft++;
                    }
                    else
                    {
                        pinkRight++;
                    }
                }

            }

            if (blueLeft == 5 && blueRight == 5 && pinkLeft == 5 && pinkRight == 5)
            {
                foreach (var ball in moveBalls)
                {
                    ball.Stop();
                }

                MessageBox.Show("Шарики разделились 50/50 по сторонам!");
            }

        }

        private void UpdatePercentLabel()
        {           
            var (bluePercentLeft, bluePercentRight) = CalculatePercent(Color.SkyBlue);
            var (pinkPercentLeft, pinkPercentRight) = CalculatePercent(Color.LightPink);
          
            procentLabel.Text = $"Синие: {bluePercentLeft}/{bluePercentRight}  \n" +
                                $"Розовые: {pinkPercentLeft}/{pinkPercentRight}";
        }

        private (int leftPercent, int rightPercent) CalculatePercent(Color color)
        {
            int halfX = this.ClientSize.Width / 2;

            int leftCount = 0;
            int rightCount = 0;
            int countBall = 10;

            foreach (var ball in moveBalls)
            {
                if (ball.color != color)
                {
                    continue;
                }

                if (ball.centerX < halfX)
                {
                    leftCount++;
                }
                else
                {
                    rightCount++;
                }
            }
          
            int leftPercent = leftCount * countBall;
            int rightPercent = rightCount * countBall;

            return (leftPercent, rightPercent);
        }
    }


    
}

