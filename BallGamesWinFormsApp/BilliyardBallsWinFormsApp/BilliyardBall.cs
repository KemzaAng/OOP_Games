
using BallCommon;

namespace BilliyardBallsWinFormsApp
{
    public class BilliyardBall : RandomMoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;

        public BilliyardBall(Form form) : base(form)
        {
        }

        protected override void Go()
        {
            base.Go();

            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }

            if  (centerX >= RightSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if(centerY >= DownSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }

            if (centerY <= TopSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
        }


    }
}
