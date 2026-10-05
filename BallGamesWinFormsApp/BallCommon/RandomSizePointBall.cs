
namespace BallCommon
{
    public class RandomSizePointBall : RandomPointBall
    {
        public RandomSizePointBall(Form form) : base(form)
        {
            radius = random.Next(15, 60);
        }

    }
}
