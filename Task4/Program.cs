// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении
// которых расположн наименьший элемент массива.

int firstLength = ReadInt("First ");
int secondLengt = ReadInt("Second");
int[,] array = CreateArray(firstLength, secondLengt);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int[] coord = FindMin(array);
Console.WriteLine();
PrintArray(DeletedColumnAndRow(coord, array));

int ReadInt(string argument)
{
  Console.Write($"Input {argument}: ");
  return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int firstLength, int secondLength ) // Создаем массив
{
  int[,] array = new int[firstLength, secondLength];

  Random random = new Random();

  for (int i = 0; i < firstLength; i++)
  {
    for (int j = 0; j < secondLength; j++)
    {
      array[i,j] = random.Next(1,10);
    }
  }

  return array;
}

void PrintArray(int[,] array) // вывод массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }

    Console.WriteLine();
  }
}

int[] FindMin(int[,] array)
{
  int[] minCord = new int [2]; // создаем одноменый массив состоящий из 2 элементов

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[minCord[0], minCord[1]] > array[i,j])
      {
        minCord[0] = i;
        minCord[1] = j;
      }
    }
  }
  Console.WriteLine(minCord[0]);
  Console.WriteLine(minCord[1]);

  return minCord;
}

int[,] DeletedColumnAndRow(int[] coord, int[,] annyArray)
{
  int[,] array = new int[annyArray.GetLength(0) -1, annyArray.GetLength(1) -1];

  int xOfSet = 0;
  int yOfSet = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == coord[0])
      {
        xOfSet = 1;
      }
      if (j == coord[1])
      {
        yOfSet = 1;
      }
      array[i,j] = annyArray[i + xOfSet, j + yOfSet];
      
    }
  }

  return array;
}
