

int[,] grid = new int[9, 9];
int[,] sudokuExample = {
            { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
        };


PrintGrid(sudokuExample);
DisplayEpochs(sudokuExample);
Console.WriteLine("· PRESS ANY KEY TO EXIT ·");
Console.ReadKey();

void PrintGrid(int[,] grid)
{
    string line = " " + new string('-', 29) + " ";

    Console.WriteLine(line);

    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            if ((j) % 3 == 0)
                Console.Write('|');
            if (grid[i, j] == 0)
            {
                Console.Write(" · ");
            }
            else
            {
                Console.Write($" {grid[i, j]} ");
            }
            if (j == 8)
                Console.Write('|');
        }
        Console.WriteLine();
        if ((i + 1) % 3 == 0)
            Console.WriteLine(line);
    }
}


void DisplayEpochs(int[,] grid)
{
    DateTime time = DateTime.Now;
    int counter = 0;

    for (int i = 0; i < 999; i++)
    {
        Console.WriteLine($"Current Time: {time.ToString("hh:mm:ss")}");
        Console.WriteLine($"Solving Sudoku... Epoch: {counter}");
        PrintGrid(grid);
        counter++;
        Console.Clear();
    }
}