using System.Drawing;
using BallCommon;

namespace DiffusionWinFormsApp
{
    public class BallBorders : RandomMoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;       

        public BallBorders(Form form, Color color) : base(form)
        {
            this.color = color;
        }

        protected override void Go()
        {
            base.Go();

            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }

            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerY >= DownSide())
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
