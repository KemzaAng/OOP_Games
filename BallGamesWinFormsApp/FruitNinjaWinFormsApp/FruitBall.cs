
using BallCommon;

namespace FruitNinjaWinFormsApp
{
    internal class FruitBall : RandomMoveBall
    {
        private static Random random = new Random();

        public float g = 0.2f;
        public readonly Color[] colors = new[]
        {
          Color.Red,
          Color.Green,
          Color.Blue,
          Color.Orange
        };

        public FruitBall(Form form) : base(form)
        {
            radius = random.Next(10, 40);       
            color = colors[random.Next(colors.Length)];

            int startX = random.Next(0, form.ClientSize.Width);
            int startY = form.ClientSize.Height;

            vy = (float)random.NextDouble() * -5 - 10;
            vx = (float)random.NextDouble() * 4 - 2;       
        }

        protected override void Go()
        {
            base.Go();

            vy += g;
        }

    }
}

