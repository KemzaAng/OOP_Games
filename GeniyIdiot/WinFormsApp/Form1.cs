
namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nextGameButton_Click(object sender, EventArgs e)
        {
            var welcomUserForm = new welcomeUserForm();
            welcomUserForm.Show();
            this.Hide();
        }

        private void resultGameButton_Click(object sender, EventArgs e)
        {
            var resultGameform = new ResultGameForm();
            resultGameform.Show();
            this.Hide();
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            var addNewQuestion = new AddNewQustionForm();
            addNewQuestion.Show();
            this.Hide();
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            var removeQuestion = new RemoveQuestionForm();
            removeQuestion.Show();
            this.Hide();
        }

        private void getOutGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}
