namespace FrogWinFormsApp
{
    public partial class MainForm : Form
    {
        private int score = 0;

        public MainForm()
        {
            InitializeComponent();
            rulesGameLabel.Text = "Правила игры:\n" +
              "1. Лягушки должны перепрыгивать на пустую кувшинку.\n" +
              "2. Прыгать можно на соседнюю кувшинку или через одну.\n" +
              "3. Прыгать дальше чем через одну кувшинку нельзя.\n" +
              "4. Минимальное количество ходов - 24. Постарайся добиться этого результата!\n" +
              "5. Игра считается выигранной, когда все лягушки, которые были слева, окажутся справа,\n" +
               "   а лягушки, которые были справа, окажутся слева, и пустая кувшинка будет в центре.";
        }

        private void PictureBoxOne_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
        }

        private void Swap(PictureBox clickePicture)
        {
            var distance = Math.Abs(clickePicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;

            if (distance > 2)
            {
                MessageBox.Show("Лягушка так далеко не прыгнет!");
            }
            else
            {
                var location = clickePicture.Location;
                clickePicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
                textJampLabel.Text = $"Количество прыжков {score + 1}";
                score += 1;
            }

            GameEnd();

        }

        private bool GameEnd()
        {
            var emptyX = emptyPictureBox.Location.X;

            var recordScore = 24;

            if (leftPictureBoxFour.Location.X > emptyX && leftPictureBoxThree.Location.X > emptyX &&
                leftPictureBoxTwo.Location.X > emptyX && leftPictureBoxOne.Location.X > emptyX &&
                rightPictureBoxFour.Location.X < emptyX && rightPictureBoxOne.Location.X < emptyX &&
                rightPictureBoxThree.Location.X < emptyX && rightPictureBoxTwo.Location.X < emptyX)
            {
                if (score == recordScore)
                {
                    MessageBox.Show($"Ты прошёл игру с минимальным счётом 24! ПОБЕДА!");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Ты прошёл игру со счётом {score}. \nПопробуй сыграть еще раз!");

                }
                Application.Restart();
            }

            return true;
        }

        private void NewGameButton_Click(object obj, EventArgs e)
        {
            Application.Restart();
        }

    }
}
