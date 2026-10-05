
namespace WinFormsApp
{
    public partial class AddNewQustionForm : Form
    {
        public string Questions;
        public int Answer;

        public AddNewQustionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string questionText = textAddQuestionBox.Text.Trim();

            if (!int.TryParse(textAnswertBox.Text.Trim(), out int answer))
            {
                MessageBox.Show("Пожалуйста, введите число от 0 до 1000!");
                return;
            }

            if (string.IsNullOrEmpty(questionText))
            {
                MessageBox.Show("Введите текст вопроса!");
                return;
            }

            var questions = QuestionsRepository.GetQuestions();

            var newQuestion = new Question(questionText, answer);

            questions.Add(newQuestion);

            QuestionsRepository.SaveQuestions(questions);

            MessageBox.Show("Вопрос успешно добавлен!");
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
