// Задайте двумернй массив. Напишете программу, которая
// поменяет местами первую и последнюю строкиу массива!




  Console.WriteLine();
  int firstLength = ReadInt("First Length");
  int secondLength = ReadInt("Second Length");

  int[,] array = CreatTwoDimensionArray(firstLength, secondLength); 
  Console.WriteLine(PrintTwoDimensionArray(array));

  int[,] newarray = ChangeStringe(array);
  Console.WriteLine(PrintTwoDimensionArray(newarray));

int ReadInt(string argument) 
{
  Console.Write($"Input {argument}: ");
  int result = 0;

  while (!int.TryParse(Console.ReadLine(), out result))
  {
    Console.WriteLine("Try again");
  }

  return result;
}

int[,] CreatTwoDimensionArray(int firstLength, int secondLength ) 
{
  Console.WriteLine();

  int[,] result = new int[firstLength, secondLength]; 
  Random rnd = new Random(); 

  for (int i = 0; i < result.GetLength(0); i++) 
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = rnd.Next(1, 10);
    }
  }
  
  return result;
}

int[,] ChangeStringe(int[,] array)
{
  int temp = 0;

  for (int j = 0; j < array.GetLength(1); j++)
  {
    temp = array[0,j];
    array[0,j] = array[array.GetLength(0) - 1, j];
    array[array.GetLength(0) - 1, j] = temp;
  }    

  return array;
}

string PrintTwoDimensionArray(int[,] array) 
{
  string result = string.Empty; 

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += $"{array[i,j]} "; 
    }
    
    result += Environment.NewLine; 
  }

  return result;
}