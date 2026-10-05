
using BallCommon;

namespace BallGamesWinFormsApp
{
    public partial class FirstForm : Form
    {
        List<RandomMoveBall> moveBalls;

        private List<Ball> balls = [];

        public FirstForm()
        {
            InitializeComponent();
            stopButton.Enabled = false;         
        }

        private void FirstForm_MouseDown(object sender, MouseEventArgs e)
        {
            var pointBall = new PointBall(this, e.X, e.Y);
            balls.Add(pointBall);
            pointBall.Move();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            int countBalls = 0;

            foreach (var moveBall in moveBalls)
            {
                moveBall.Stop();

                if (moveBall.OnForm())
                {
                    countBalls++;
                }
            }

            MessageBox.Show($"Количество шаров: {countBalls}");
        }

        private void MoreBallButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;

            if (moveBalls != null)
            {
                foreach (var oldBall in moveBalls)
                {
                    oldBall.Stop();
                }
            }

            balls.Clear();
            this.Invalidate();

            moveBalls = new List<RandomMoveBall>();

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new RandomMoveBall(this);
                moveBalls.Add(moveBall);

                balls.Add(moveBall);
                moveBall.Start();
            }
        }

    }
}
