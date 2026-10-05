
using BallCommon;

namespace FireWorkWinFormsApp
{
    public class FireWorkBall : RandomMoveBall
    {
        public float g = 0.2f;     

        public FireWorkBall(Form form, int centerX, int centerY) : base(form)
        {
            radius = 4;           
            this.centerX = centerX;
            this.centerY = centerY;

            vy = -Math.Abs(vy);
        }

        protected override void Go()
        {
            base.Go();

            vy += g;
        }

    }
}
