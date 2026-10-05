
namespace _2048WinFormsApp
{
    public partial class RulesOfTheGameForm : Form
    {
        public RulesOfTheGameForm()
        {
            InitializeComponent();
        }

        private void RulesOfTheGameForm_Load(object sender, EventArgs e)
        {
            textRulesGameLabel.Text =
                "Цель игры 2048 — передвигать плитки с числами на поле 4×4 так,\r\n" +
                "чтобы объединить одинаковые плитки и получить плитку с числом 2048.\r\n\r\n" +
                "Каждое движение заставляет все плитки перемещаться в указанном направлении — вверх,\r\n" +
                "вниз, влево или вправо, — пока они не остановятся или не объединятся с другими одинаковыми плитками.\r\n\r\n" +
                "После каждого хода на поле появляется новая плитка с числом 2 или 4.\r\n\r\n" +
                "Если поле заполнится, а объединить плитки будет невозможно — игра заканчивается.\r\n\r\n" +
                "Стандартный размер поля — 4×4,\r\nно в меню игры можно выбрать другой размер поля.";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
