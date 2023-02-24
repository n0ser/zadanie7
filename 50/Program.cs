Console.WriteLine("Определить позицию элемента в двумерном массиве и найти его значение");
Console.Write("Строка: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 3; 
int m = 4; 

Random random = new Random();

int[,] arr = new int[n, m];

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(1, 10);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();