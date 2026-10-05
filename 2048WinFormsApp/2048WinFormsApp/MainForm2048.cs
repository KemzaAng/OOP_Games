
namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private int mapSize;
        private const int cellSize = 70;
        private const int cellSpacing = 6;
        private int offsetX = 70;
        private int offsetY = 120;

        private Color defaultCellColor = Color.NavajoWhite;
        private Font defaultCellFont = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        private ContentAlignment defaultTextAlignment = ContentAlignment.MiddleCenter;

        private Label[,] labelsMap;
        private Random random = new Random();
        private int score = 0;
        private int recordScore;

        User user;

        public MainForm(User user, int mapSize)
        {
            InitializeComponent();

            this.user = user;
            this.mapSize = mapSize;

        }

        private void Form1_Load(object sender, EventArgs e)
        {                 
            InitMap();
            GenerateNumber();
            ShowScore();           

            recordScore = UsersScore.LoadRecord();
            RecordScoreLabel.Text = recordScore.ToString();
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }

        private void InitMap()
        {
            int fieldWidth = mapSize * cellSize + (mapSize - 1) * cellSpacing + offsetX * 2;
            int fieldHeight = mapSize * cellSize + (mapSize - 1) * cellSpacing + offsetY + 50;

            this.ClientSize = new Size(fieldWidth, fieldHeight);

            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);

                    Controls.Add(newLabel);

                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private void GenerateNumber()
        {
            var emptyCells = new List<(int row, int column)>();

            for (int row = 0; row < mapSize; row++)
            {
                for (int column = 0; column < mapSize; column++)
                {
                    if (labelsMap[row, column].Text == string.Empty)
                    {
                        emptyCells.Add((row, column));
                    }
                }
            }

            if (emptyCells.Count == 0)
            {
                return;
            }

            var randomCell = emptyCells[random.Next(emptyCells.Count)];

            int indexRow = randomCell.row;
            int indexColumn = randomCell.column;

            int chance = random.Next(100);

            if (chance < 75)
            {
                labelsMap[indexRow, indexColumn].Text = "2";
            }
            else
            {
                labelsMap[indexRow, indexColumn].Text = "4";
            }

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
                GenerateNumber();
            }

            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
                GenerateNumber();
            }

            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
                GenerateNumber();
            }

            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
                GenerateNumber();
            }

            ShowScore();
            UpdateRecord();
            CheckGameOver();          

        }

        public void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;

                                break;
                            }

                        }
                    }
                }
            }
        }

        public void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;

                                break;
                            }

                        }
                    }

                }
            }
        }

        public void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        public void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label
            {
                BackColor = defaultCellColor,
                Font = defaultCellFont,
                Size = new Size(cellSize, cellSize),
                TextAlign = defaultTextAlignment
            };

            int x = offsetX + indexColumn * (cellSize + cellSpacing);
            int y = offsetY + indexRow * (cellSize + cellSpacing);

            label.Location = new Point(x, y);

            label.TextChanged += RecordingCellColor;  

            return label;
        }

        private void RecordingCellColor(object sender, EventArgs e)
        {
            var label = (Label)sender;

            if (string.IsNullOrEmpty(label.Text))
            {
                label.BackColor = Color.NavajoWhite; 
                return;
            }

            int value = int.Parse(label.Text);
            
            switch (value)
            {
                case 2: label.BackColor = Color.Linen; break;
                case 4: label.BackColor = Color.Tan; break;
                case 8: label.BackColor = Color.Goldenrod; break;
                case 16: label.BackColor = Color.Gold; break;
                case 32: label.BackColor = Color.DarkGoldenrod; break;
                case 64: label.BackColor = Color.DarkKhaki; break;
                case 128: label.BackColor = Color.LightSalmon; break;
                case 256: label.BackColor = Color.Orange; break;
                case 512: label.BackColor = Color.PaleVioletRed; break;
                case 1024: label.BackColor = Color.Tomato; break;
                case 2048: label.BackColor = Color.Chocolate;break;
                default: label.BackColor = Color.LightYellow; break; 
            }
        }     

        private void StartNewGame()
        {
            score = 0;
            ShowScore();

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    labelsMap[i, j].Text = string.Empty;
                }
            }

            GenerateNumber();
        }
       
        private void CheckGameOver()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (string.IsNullOrEmpty(labelsMap[i, j].Text))
                    {
                        return;
                    }

                    if (!string.IsNullOrEmpty(labelsMap[i, j].Text))
                    {
                        int value = int.Parse(labelsMap[i, j].Text);

                        if (value == 2048)
                        {
                            MessageBox.Show("Вы выиграли!", "2048", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            StartNewGame();
                            return;
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    int current = int.Parse(labelsMap[i, j].Text);

                    if (j + 1 < mapSize && labelsMap[i, j + 1].Text != string.Empty)
                    {
                        if (current == int.Parse(labelsMap[i, j + 1].Text))
                        {
                            return;
                        }
                    }

                    if (i + 1 < mapSize && labelsMap[i + 1, j].Text != string.Empty)
                    {
                        if (current == int.Parse(labelsMap[i + 1, j].Text))
                        {
                            return;
                        }
                    }
                }
            }

            MessageBox.Show("Игра закончена!", "2048", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartNewGame();

            UsersScore.Save(user);

        }
        private void UpdateRecord()
        {
            scoreLabel.Text = score.ToString();
         
            if (score > recordScore)
            {
                recordScore = score;
                RecordScoreLabel.Text = recordScore.ToString();
            }

            user.SetScore(score);           

        }

        private void MenuLabel_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void NewGameLabel_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

    }
}

