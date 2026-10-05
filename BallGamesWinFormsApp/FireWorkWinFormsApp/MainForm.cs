
namespace FireWorkWinFormsApp
{
    public partial class MainForm : Form
    {
        Random random = new Random();

        public readonly Color[] colors = new[]
        {
            Color.LimeGreen, Color.Magenta, Color.Cyan, Color.Red,
            Color.Gold, Color.HotPink, Color.Lime, Color.DeepSkyBlue,
            Color.Orange, Color.Violet
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var ball = new FlyingBall(this);
            ball.TopReached += Ball_TopReached;
            ball.Start();

            var count = random.Next(15, 30);

            for (int i = 0; i < count; i++)
            {
                var firework = new FireWorkBall(this, e.X, e.Y);
                firework.color = colors[random.Next(colors.Length)];
                firework.Start();
            }

        }

        private void Ball_TopReached(object sender, TopReachedEventArgs e)
        {
            for (int i = 0; i < random.Next(7, 15); i++)
            {
                var firework = new FireWorkBall(this, (int)e.X, (int)e.Y);
                firework.color = colors[random.Next(colors.Length)];
                firework.Start();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}