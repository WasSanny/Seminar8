// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

Dictionary<int, int> dictionary = new Dictionary<int, int>();

int[] array = GetArray(25);

PrintArray(array);
FillDictionary(dictionary, array);
Console.WriteLine();
Console.WriteLine();
PrintDictionary(dictionary);



int[] GetArray(int length)
{
  int[] array = new int[length];

  Random random = new Random();

  for (int i = 0; i < length; i++)
  {
    array[i] = random.Next(0, 10);
  }

  return array;
}

int ReadInt(string argument)
{
  Console.Write($"Input {argument}: ");
  return int.Parse(Console.ReadLine());
}

void FillDictionary(Dictionary<int, int> dictionary, int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (dictionary.ContainsKey(array[i]))
    {
      dictionary[array[i]]++;
    }
    else
    {
      dictionary.Add(array[i], 1);
    }
  }
}

void PrintDictionary(Dictionary<int, int> dictionary)
{
  foreach (var pair in dictionary)
  {
    Console.WriteLine($"{pair.Key} ------ {pair.Value}");
  }
}

void PrintArray(int[] array)
{
  foreach (var pair in array)
  {
    Console.Write($"{pair} ");
  }
}