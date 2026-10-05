using BallCommon;

namespace AngryBirdsGameWinFormsApp
{
    internal class PigBall : Ball
    {
        public static Random random = new Random();

        public PigBall(Form form) : base(form)
        {
            color = Color.LightGreen;

            radius = 30;

            centerX = random.Next(radius, form.ClientSize.Width - radius);
            centerY = random.Next(radius, form.ClientSize.Height - radius);
            
            vx = 0;
            vy = 0;
                     
        }

        public void DrawPig(Graphics g)
        {
            var brush = new SolidBrush(color);
            g.FillEllipse(brush, centerX - radius, centerY - radius, radius * 2, radius * 2);
            brush.Dispose();
        }
    }
}
