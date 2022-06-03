//Найти произведение двух матриц
void FillMatrix(double[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        any[i, j] = new Random().Next(0, 10);
    }
}
}
void PrintMatrix(double[,] any)
{
for(int i = 0; i < any.GetLength(0); i++) 
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        Console.Write($"{any[i, j]} ");
    }
Console.WriteLine();
}
}
Console.WriteLine("How much rows in matrix?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in matrix?");
int columns = int.Parse(Console.ReadLine());
double[,] matrix1 = new double[rows, columns];
double[,] matrix2 = new double[rows, columns];
double[,] matrix3 = new double[rows, columns];
FillMatrix(matrix1);
FillMatrix(matrix2);
Console.WriteLine("First matrix:");
PrintMatrix(matrix1);
Console.WriteLine("Second matrix:");
PrintMatrix(matrix2);
for(int i = 0; i < matrix1.GetLength(0); i++)
{
    for(int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix3[i, j] = matrix1[i,j] * matrix2[i, j];
    }
}
Console.WriteLine("Product of two matrix:");
PrintMatrix(matrix3);


