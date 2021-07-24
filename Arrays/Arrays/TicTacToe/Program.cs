using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static int _r;
        private static int _c;
        private static char _turn = 'X';
        private static char _outcome = ' ';
        private static void Main(string[] args)
        {
            InitBoard();
            int i = 0;
            DisplayBoard();
            do
            {
                i++;
                MakeTurn();
                Console.Clear();                            
                DisplayBoard();
                GetWinner();
                if (i == 9 && _outcome == ' ')
                    _outcome = 'T';
            }
            while (_outcome == ' ');

            if (_turn == 'T')
                Console.WriteLine("The game is a tie.");
            else
                Console.WriteLine($"{_turn} win!");
            Console.ReadKey();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("     +--+---+---+");
            Console.WriteLine("  0  |" + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2] + " |");
            Console.WriteLine("     +--+---+---+");
            Console.WriteLine("  1  |" + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + " |");
            Console.WriteLine("     +--+---+---+");
            Console.WriteLine("  2  |" + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + " |");
            Console.WriteLine("     +--+---+---+");
        }

        private static void MakeTurn()
        {
            _turn = _turn == 'X' ? 'O' : 'X';
            bool isCorrect = true;
            do
            {
                isCorrect = true;
                Console.WriteLine($"{_turn} turn!");
                Console.WriteLine("Enter row:");
                _r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter column:");
                _c = Convert.ToInt32(Console.ReadLine());
                if (_c > 2 || _r > 2 || board[_r, _c] != ' ')
                {
                    Console.WriteLine("Incorrect input! Try again!");
                    isCorrect = false;
                }
            }
            while (!isCorrect);
            board[_r, _c] = _turn;            
        }

        private static void GetWinner()
        {
            if ((board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 2] != ' ')
             || (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 2] != ' ')
             || (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 2] != ' ')
             || (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[2, 0] != ' ')
             || (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[2, 1] != ' ')
             || (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[2, 2] != ' ')
             || (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] != ' ')
             || (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] != ' '))
                _outcome = _turn;
        }
    }
}
