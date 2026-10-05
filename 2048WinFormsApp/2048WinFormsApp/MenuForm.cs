
namespace _2048WinFormsApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void gameMenuButton_Click(object sender, EventArgs e)
        {
            UserNameForm userNameForm = new UserNameForm();           
            userNameForm.Show();
            this.Hide();
           
        }

        private void HistoryGameButton_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.Show();
            this.Hide();
        }

        private void RulesGameButton_Click(object sender, EventArgs e)
        {
            RulesOfTheGameForm rulesOfTheGameForm = new RulesOfTheGameForm();       
            rulesOfTheGameForm.Show();        
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {         
            this.Hide();          
            Application.Exit();
        }
    }

}
