// Задайте двумернй массив. Напишете программу, которая
// поменяет строки на столбцы

int[,] array = CreateArray(ReadInt("First "), ReadInt("Second"));
Console.WriteLine();

PrintArray(array);

Console.WriteLine();
Console.WriteLine();

if (ChangeRowsAndColumns(ref array))
{
  PrintArray(array);
}
else
{
  Console.WriteLine("Ooooops");
}


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

bool ChangeRowsAndColumns(ref int[,] array) // проверяем, квадратный ли массив и если нет, то выводим ошибку
{
  if (array.GetLength(0) != array.GetLength(1))
  {
    return false;
  }

  array = CopyArray(array);

  return true;
}

int[,] CopyArray(int[,] array)  // копируем массив и переворачиваем строки со столбцами
{
  int[,] copieArray = new int [array.GetLength(1), array.GetLength(1)];

  for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      copieArray[i, j] = array[j, i];
    }
  }

  return copieArray;
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