using ConSnake2;

bool isGameOver;

GameBoard gameBoard = new(100, 30);

void NewGame()
{
    isGameOver = false;
   
    

    //Fetch level selection
    int difficulty;
    bool isValidInput;
    do
    {
        char key = Console.ReadKey(true).KeyChar;
        isValidInput = int.TryParse(key.ToString(), out difficulty) && difficulty > 0;
    }
    while (!isValidInput);

    Console.Clear();
}