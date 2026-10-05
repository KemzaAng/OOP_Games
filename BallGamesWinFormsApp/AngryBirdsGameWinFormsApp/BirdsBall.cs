using BallCommon;

namespace AngryBirdsGameWinFormsApp
{
    internal class BirdsBall : Ball
    {
        private Form form;           

        public BirdsBall(Form form) : base(form)
        {
            this.form = form;
            color = Color.Red;
            radius = 15;

            centerX = 30;  
            centerY = form.ClientSize.Height - radius - 10;

            vx = 0;
            vy = 0;          
        }      

        public void Shoot(float powerX, float powerY)
        {
            vx = powerX;
            vy = -powerY;           
        }
   
        protected override void Go()
        {
            base.Go();
  
            vy += 0.3f;
            var bounceFactor = 0.8f;


            if (centerX - radius <= 0)
            {
                centerX = radius;
                vx = -vx * bounceFactor;
            }

            if (centerX + radius >= RightSide())
            {
                centerX = RightSide() - radius;
                vx = -vx * bounceFactor;
            }

            if (centerY - radius <= 0)
            {
                centerY = radius;
                vy = -vy * bounceFactor;
            }

            if (centerY + radius >= DownSide())
            {
                centerY = DownSide() - radius;
                vy = -vy * bounceFactor;
                vx *= 0.9f; 
            }

            float maxJumpHeight = DownSide() - (centerY + radius); 
            if (Math.Abs(vy) < 1.0f && maxJumpHeight < 5f)
            {
                vx = 0;
                vy = 0;

                centerX = 30;
                centerY = form.ClientSize.Height - radius - 10;
            }
        }

        internal void Draw(Graphics graphics)
        {
            using var brush = new SolidBrush(this.color);
            graphics.FillEllipse(brush, centerX - radius, centerY - radius, radius * 2, radius * 2);
        }
    }
}
