/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */

bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Задайте размер массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] arr = new int[size];
    var newRnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = newRnd.Next(100, 1000);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    void FindChet(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count++;
        }
        Console.WriteLine($"Число чётных элементов = {count}");
    }
    FindChet(arr);
    
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}