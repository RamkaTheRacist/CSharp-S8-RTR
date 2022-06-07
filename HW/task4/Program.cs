void FillMatrix(int[,] matrix)
{
    int f0 = 1;
    for(int i = 1; i< matrix.GetLength(0); i++)
    {
        for(int j = 1; j<matrix.GetLength(1) - 1; j++)
        {
            matrix[i,0] = f0;
            matrix[i,(matrix.GetLength(1) - 1)] = f0;
            matrix[i,j] = matrix[i - 1,j] + matrix[i - 1, j-1];
        }
    }
}
//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.WriteLine("How much numbers?");
int number = int.Parse(Console.ReadLine());
int[,] matrix = new int[number + 2, number + 2];
FillMatrix(matrix);
Console.Clear();
for(int i = 1; i< matrix.GetLength(0); i++)
{
    for(int j = 0; j<matrix.GetLength(1); j++)
    {
        if(matrix[i,j] == 0) continue;
        if(j == matrix.GetLength(1) - 1) continue;
        else 
        {
            Console.SetCursorPosition((10 + (j * number/2)),i);
            Console.Write($"{matrix[i,j]}");
        }
    }
    Console.WriteLine();
}
//Да, я валенок, который не смог в равнобедренный треугольник, сорян
