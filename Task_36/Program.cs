/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19 
[-4, -6, 89, 6] -> 0 */

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
        arr[i] = newRnd.Next(1, 10);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    int FindSum(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            count+=array[i];
        }
        return count;
    }
    Console.WriteLine(FindSum(arr));
    
    
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}