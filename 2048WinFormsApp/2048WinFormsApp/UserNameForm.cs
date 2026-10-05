namespace _2048WinFormsApp
{
    public partial class UserNameForm : Form
    {
        public int mapSize;
        public UserNameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Пожалуйста, введите имя!");
                return;
            }          
            if (mapSize == 0)
            {
                MessageBox.Show("Пожалуйста, выберите размер поля!");
                return;
            }

            var user = new User(userName);

            MainForm gameForm = new MainForm(user, mapSize);
            gameForm.Show();
            this.Hide();

        }         

        private void FourRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mapSize = 4;
        }

        private void SixRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mapSize = 6;
        }

        private void NineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mapSize = 9;
        }
    }
}
