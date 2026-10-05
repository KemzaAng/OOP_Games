
namespace FireWorkWinFormsApp
{
    public class FlyingBall : FireWorkBall
    {
        public event EventHandler<TopReachedEventArgs> TopReached;

        private static Random random = new Random();
        
        public FlyingBall(Form form) : base(form, random.Next(0, form.ClientSize.Width),form.ClientSize.Height) 
        {                 
            int startX = random.Next(0, form.ClientSize.Width);

            int startY = form.ClientSize.Height;           

            vy = (float)random.NextDouble() * -5 - 10;
            vx = (float)random.NextDouble() * 4 - 2;   
        }

        protected override void Go()
        {
            base.Go();

            if (vy > 0)
            {
                Stop(); 
                Clear(); 
                TopReached?.Invoke(this, new TopReachedEventArgs(centerX, centerY));
            }
            
        }
    }
}
