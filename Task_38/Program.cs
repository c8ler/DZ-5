/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76 */


bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Введите массив через пробелы: ");
    double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
    double FindDiv(double[] arr)
    {
        double min = arr[0];
        double max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        double div = max - min;
        return div;
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {FindDiv(array)}");
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}
