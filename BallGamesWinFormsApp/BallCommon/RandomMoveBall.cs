
namespace BallCommon
{
    public class RandomMoveBall : RandomPointBall
    {
        public RandomMoveBall(Form form) : base(form)
        {
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
        }
    }
}
