
namespace WinFormsApp
{
    public partial class welcomeUserForm : Form
    {
        public welcomeUserForm()
        {
            InitializeComponent();
        }

        private void intoGameButton_Click(object sender, EventArgs e)
        {
            string playerName = textUserNameBox.Text.Trim();

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Пожалуйста, введите имя!");
                return;
            }
            var newGame = new NewGame();
            newGame.PlayerName = playerName;
            newGame.Show();
            this.Hide();
        }
    }
}
