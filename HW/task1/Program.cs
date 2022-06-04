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
double[] array = new double[rows];
for(int z = 0; z< matrix3.GetLength(0); z++)
{
    for(int j = 0; j < matrix1.GetLength(0); j++)
    {
        double tmp = 0;
        for(int i = 0; i<matrix1.GetLength(1); i++)
        {
            array[i] = matrix1[z,i] * matrix2[i,j];
            tmp = tmp + array[i];
        }
        matrix3[z,j] = tmp;
    }
}
Console.WriteLine("Product of two matrix:");
PrintMatrix(matrix3);




