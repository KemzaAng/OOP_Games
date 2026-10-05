
namespace WinFormsApp
{
    public partial class ResultGameForm : Form
    {   

        public ResultGameForm()
        {
            InitializeComponent();
        }

        private void resultGameForm_Load(object sender, EventArgs e)
        {      
            var results = UsersResultStorage.LoadAll();
            foreach (var result in results)
            {
                dataGridView.Rows.Add(result.Name, result.CorrectAnswers, result.Diagnosis);
            }

        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
