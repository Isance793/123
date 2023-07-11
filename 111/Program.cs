using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива (каждый элемент на новой строке):");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }

        string[] newArray = FilterArray(array);

        Console.WriteLine("Новый массив со строками длиной не более 3 символов:");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }

    static string[] FilterArray(string[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[index] = array[i];
                index++;
            }
        }

        return newArray;
    }
}
