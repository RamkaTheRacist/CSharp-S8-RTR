//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
void FillMatrix(int[,,] any)
{
    int res = -99;
    for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        for(int k = 0; k < any.GetLength(2); k++)
        {
            if(res < -9)
            {
                any[i,j,k] = res;
                res++;
            }
            else if(10 < res & res < 100)
            {
                any[i,j,k] = res;
                res++;
            }
            else if(-9 >= res & res < 10)
            {
                res = 10;
                any[i,j,k] = res;
                res++;
            }
        }
    }
}
}
void PrintMatrix(int[,,] any)
{
    for(int i = 0; i < any.GetLength(0); i++) 
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        for(int k = 0; k < any.GetLength(2); k++)
        {
        Console.Write($"{any[i, j, k]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
}
void PrintResult(int[,,] any)
{
for(int i = 0; i < any.GetLength(0); i++) 
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        for(int k = 0; k < any.GetLength(2); k++)
        {
        Console.WriteLine($"index of {any[i, j, k]} = {i}, {j}, {k}");
        }
    }
}
}

Console.WriteLine("Which size?");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());
int[,,] any = new int[first, second, third];
if(first * second * third <= 180)
{
    FillMatrix(any);
    PrintResult(any);
}
else Console.WriteLine("Error input data. Too big sizes");


