
namespace WinFormsApp
{
    public partial class NewGame : Form
    {
        private List<Question> _questions;
        private Question _currentQuestion;
        User user;
        private int _countQuestions;
        private int _correctAnswersCount;
        private int _questionNumber = 1;
        public string PlayerName;

        public NewGame()
        {
            InitializeComponent();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            user = new User(PlayerName);
            _questions = QuestionsRepository.GetQuestions();
            _countQuestions = _questions.Count;

            ShowNextQuestions();

        }
        private void ShowNextQuestions()
        {
            Random randomGenerator = new Random();
            var randomIndex = randomGenerator.Next(0, _questions.Count);
            _currentQuestion = _questions[randomIndex];
            textQuestionLabel.Text = _currentQuestion.Text;

            questionNumberLabel.Text = "Вопрос №" + _questionNumber;
            _questionNumber++;
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            int userAnswer;

            if (!int.TryParse(answerQuestionTextBox.Text, out userAnswer))
            {
                MessageBox.Show("Пожалуйста, введите число от 0 до 1000!");
                return;
            }

            if (userAnswer == _currentQuestion.Answer)
            {
                _correctAnswersCount++;
            }

            _questions.Remove(_currentQuestion);

            if (_questions.Count == 0)
            {
                user.Diagnosis = Diagnosis.GiveStatus(_correctAnswersCount, _countQuestions);
                user.SetResult(_correctAnswersCount, user.Diagnosis);

                UsersResultStorage.Save(user);

                MessageBox.Show($"Игра окончена!\nПравильных ответов: {_correctAnswersCount}\nВаш диагноз, {user.Name}: {user.Diagnosis}");

                var mainForm = new MainForm();
                mainForm.Show();
                this.Close();

                return;
            }

            ShowNextQuestions();
        }
        

    }
}
