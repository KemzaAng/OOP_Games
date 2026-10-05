
namespace _2048WinFormsApp
{
    public partial class ResultForm : Form
    {       
        public ResultForm()
        {
            InitializeComponent();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {           
            var results = UsersScore.LoadAll();
            foreach (var result in results)
            {
                dataGridView.Rows.Add(result.Name, result.Score);
            }
        }
    }
}
