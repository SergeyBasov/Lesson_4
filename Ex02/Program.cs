// Двумерные массивы 

int [,] matrix = new int[5,4];

for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine();
}
