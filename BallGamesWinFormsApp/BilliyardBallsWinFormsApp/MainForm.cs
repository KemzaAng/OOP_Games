namespace BilliyardBallsWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10 ; i++)
            {
                var ball = new BilliyardBall(this);
                ball.OnHited += Ball_OnHited;
                ball.Start();
            }
        }

        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            switch(e.side)
            {
                case Side.Left: leftLabel.Text = (int.Parse(leftLabel.Text) + 1).ToString(); break;
                case Side.Right: rightLabel.Text = (int.Parse(rightLabel.Text) + 1).ToString(); break;
                case Side.Top: topLabel.Text = (int.Parse(topLabel.Text) + 1).ToString(); break;
                case Side.Down: downLabel.Text = (int.Parse(downLabel.Text) + 1).ToString(); break;                           

            }
        }
    }
}
