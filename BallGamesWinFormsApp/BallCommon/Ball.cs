
using Timer = System.Windows.Forms.Timer;

namespace BallCommon
{
    public class Ball
    {
        public float vx = -4;
        public float vy = 7;
        public Color color = Color.Chocolate;

        private Timer timer;

        private Form form;

        public int centerX = 150;
        public int centerY = 150;
        public int radius = 30;
        protected Random random = new Random();

        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += Timer_Tick;        
        }      

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();      
        }
        public bool IsMoves()
        {
            return timer.Enabled;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public int LeftSide()
        {
            return radius;
        }

        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public void Show()
        {
            var brush = new SolidBrush(color);
            Draw(brush);
            brush.Dispose();
        }

        public bool Contains(int pointx, int pointy)
        {
            int dx = pointx - centerX;
            int dy = pointy - centerY;
            return dx * dx + dy * dy <= radius * radius;
        }

        protected virtual void Go()
        {
            centerX += (int)vx;
            centerY += (int)vy;          
        }

        public void Clear()
        {
            var graphics = form.CreateGraphics();
            var rect = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(new SolidBrush(form.BackColor), rect); 
        }

        public bool OnForm()
        {
            return centerX >= LeftSide() && centerX >= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }

        public void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rect = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rect);
        }

        public bool IsHit(float x, float y)
        {
            float dx = x - centerX;
            float dy = y - centerY;
            return Math.Sqrt(dx * dx + dy * dy) <= radius;
        }
    }
}
