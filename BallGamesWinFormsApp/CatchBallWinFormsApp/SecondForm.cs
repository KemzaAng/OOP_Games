using BallCommon;

namespace CatchBallWinFormsApp
{
    public partial class SecondForm : Form
    {
        private List<RandomMoveBall> moveBalls;
        private int countBalls = 0;

        public SecondForm()
        {
            InitializeComponent();
        }

        private void SecondForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveBalls != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (moveBalls[i].IsMoves() && moveBalls[i].Contains(e.X, e.Y))
                    {
                        moveBalls[i].Stop();
                        countBalls++;
                    }

                    CountBallLabel.Text = countBalls.ToString();
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            countBalls = 0;
            CountBallLabel.Text = "0";

            if (moveBalls != null)
            {
                foreach (var oldBall in moveBalls)
                {
                    oldBall.Stop();
                }
            }

            this.Invalidate();

            moveBalls = new List<RandomMoveBall>();

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new RandomMoveBall(this);
                moveBalls.Add(moveBall);

                moveBall.Start();
            }
        }

   
        
    }
}
