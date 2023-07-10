class Program
{
    static void Main(string[] args)
    {

        System.Console.Write("Введите количество элементов массива:");

        int elementsCount = int.Parse(Console.ReadLine());

        int[] array = new int[elementsCount];
        
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.WriteLine($"Введите элемент массива под индексом {i} ");
            array[i] = int.Parse(Console.ReadLine());
        }

        System.Console.WriteLine("Вывод массива");

        for (int i = 0; i < array.Length; i++)
        {
            System.Console.WriteLine(array[i]);
        }

        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            int randomIndex = random.Next(0, array.Length);
            System.Console.WriteLine(array[randomIndex]);
        }

        Console.ReadLine();

    }
}