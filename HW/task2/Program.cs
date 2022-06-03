//В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillMatrix(int[,] any)
{
    for(int i = 0; i < any.GetLength(0); i++)
{
    for(int j = 0; j < any.GetLength(1); j++)
    {
        any[i, j] = new Random().Next(0, 10);
    }
}
}
void PrintMatrix(int[,] any)
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
int SearchingMinNumber(int[,] matrix)
{
int min = 100;
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++) if(min > matrix[i,j]) min = matrix[i, j];
}
return min;
}
int Count(int[,] matrix, int min)
{
int count = 0;
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++) if(matrix[i,j] == min) count++;
}
return count;
}
void ChangeIndexOfRows(int[,] any)
{
bool check = false;
int i = 0;
int j = 0;
while(check == false)
{
    for(i = 0; i < any.GetLength(0); i++) 
    {
                for(j = 0; j < any.GetLength(1) - 1; j++)
                {
                        if(any[i,j] == 0)
                        {
                            int tmp = any[i, j];
                            any[i, j] = any[i, j + 1]; 
                            any[i, j + 1] = tmp;
                        }
                        else check = true;
                }
    }
    if(check == true) continue;
}
}
void ChangeIndexOfCol(int[,] any)
{
bool check = false;
int i = 0;
int j = 0;
while(check == false)
{
    for(i = 0; i < any.GetLength(0) - 1; i++) 
    {
                for(j = 0; j < any.GetLength(1); j++)
                {
                        if(any[i,j] == 0)
                        {
                            int tmp = any[i, j];
                            any[i, j] = any[i + 1, j]; 
                            any[i + 1, j] = tmp;
                            
                        }
                        else check = true;
                }
    }
    if(check == true) continue;
}
}
Console.WriteLine("How much rows in matrix?");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("How much columns in matrix?");
int columns = int.Parse(Console.ReadLine());
int[,] matrix1 = new int[rows, columns];
FillMatrix(matrix1);
Console.WriteLine("Filled Matrix:");
PrintMatrix(matrix1);
int count = Count(matrix1, SearchingMinNumber(matrix1));
int min = SearchingMinNumber(matrix1);
int[] positionI = new int[Count(matrix1, SearchingMinNumber(matrix1))];
int[] positionJ = new int[Count(matrix1, SearchingMinNumber(matrix1))];

int forarray = 0;
for(int i = 0; i < matrix1.GetLength(0); i++)
{
    for(int j = 0; j < matrix1.GetLength(1); j++)
    {
        if(matrix1[i,j] == min)
        {
            positionI[forarray] = i;
            positionJ[forarray] = j;
            forarray++;
        }
    }
}
for(int b = 0; b < positionI.Length; b++)
{
    for(int i = 0; i < matrix1.GetLength(0); i++) 
    {
            for(int j = 0; j < matrix1.GetLength(1); j++)
            {
                if(i == positionI[b])
                matrix1[positionI[b], j] = 0;
                if(j == positionJ[b])
                matrix1[i,positionJ[b]] = 0;
                
            }
    }
}
Console.WriteLine();
Console.WriteLine("Null in matrix instead of minimal number:");
PrintMatrix(matrix1);
for(int i = 0; i < matrix1.GetLength(1); i++) 
{
ChangeIndexOfRows(matrix1); 
}
for(int i = 0; i < matrix1.GetLength(0); i++) 
{
ChangeIndexOfCol(matrix1);
}
Console.WriteLine();
Console.WriteLine("Changed positions in matrix:");
PrintMatrix(matrix1);
int sizeofcolumns = 0;
for(int i = 0; i < matrix1.GetLength(1); i++)
{
    if(matrix1[0,i] > 0)
        {
            sizeofcolumns++;
        }

}
int sizeofrows = 0;
for(int i = 0; i < matrix1.GetLength(0); i++)
{
    if(matrix1[i,0] > 0)
        {
            sizeofrows++;
        }

}
int[,] matrix2 = new int[sizeofrows, sizeofcolumns];
for(int i = 0; i < matrix2.GetLength(0); i++)
{
    for(int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i,j] = matrix1[i,j];
    }
}
Console.WriteLine();
Console.WriteLine("New matrix:");
PrintMatrix(matrix2);