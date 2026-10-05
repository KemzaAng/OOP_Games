
namespace WinFormsApp
{
    public partial class RemoveQuestionForm : Form
    {        
        private List<Question> _questions;
        public RemoveQuestionForm()
        {
            InitializeComponent();
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите вопрос для удаления.");
                return;
            }
         
            int index = dataGridView1.SelectedRows[0].Index;

            _questions.RemoveAt(index);
         
            QuestionsRepository.SaveQuestions(_questions);

            dataGridView1.Rows.RemoveAt(index);            

            MessageBox.Show("Вопрос успешно удален!");
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }     

        private void removeQuestionForm_Load(object sender, EventArgs e)
        {
            _questions = QuestionsRepository.GetQuestions();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Index", "№");
            dataGridView1.Columns.Add("Question", "Вопрос");

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 600;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Cursor = Cursors.Default;

            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.ColumnHeadersVisible = true;

            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;

            dataGridView1.Rows.Clear();
            for (int i = 0; i < _questions.Count; i++)
            {
                dataGridView1.Rows.Add(i + 1, _questions[i].Text);
            }
        }
    }
}
