namespace Guess
{
    public partial class Form1 : Form
    {
        private List<GameButton> buttons = new();
        private int number;
        private int tries = 0;
        private int boardSize = 25;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();            
        }

        private void NewGame()
        {
            tries = 0;
            number = Random.Shared.Next(1, boardSize * boardSize);
            lblResult.Text = "Guess a number!";

            DrawGameBoard();
        }

        private void GameOver(int value)
        {
            buttons.ForEach(x =>
            {
                if (x.Value != value) x.Enabled = false;
            });
        }

        private void DisableButtons(int value, bool tooLow)
        {
            if (tooLow) buttons
                    .FindAll(x => x.Value <= value)
                    .ForEach(x => x.Enabled = false);
            else buttons
                    .FindAll(x => x.Value >= value)
                    .ForEach(x => x.Enabled = false);
        }

        private void DrawGameBoard()
        {
            pGameArea.Controls.Clear();
            buttons = new();

            int size = 50;
            int value = 0;

            for (int y = 0; y < boardSize; y++)
            {
                for (int x = 0; x < boardSize; x++)
                {
                    GameButton gameButton = new(value++)
                    {
                        Size = new(size, size),
                        Location = new(x * size, y * size),
                        Text = value.ToString(),
                    };
                    gameButton.Click += new(GameButton_Click);
                    pGameArea.Controls.Add(gameButton);
                    buttons.Add(gameButton);
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            tries++;
            lblTries.Text = tries.ToString();
            GameButton clickedButton = (GameButton)sender;

            if (clickedButton.Value < number)
            {
                lblResult.Text = "Too Low!";
                DisableButtons(clickedButton.Value, true);
            }
            else if (clickedButton.Value > number)
            {
                lblResult.Text = "Too High!";
                DisableButtons(clickedButton.Value, false);
            }
            else
            {
                lblResult.Text = "Correct!";
                GameOver(clickedButton.Value);
            }
        }
    }
}