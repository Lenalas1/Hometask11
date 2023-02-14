//task 34
//void InputArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//        array[i] = new Random().Next(100,1000);
//}


//int CountEvenArray (int[] array)
//{
//    int count = 0;
//foreach(int element in array)
//{
//    if (element % 2 == 0)
//        count++;
//}
//return count;
//}


//Console.Clear();
//Console.Write("Введите кол-во элементов массива: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[n];
//InputArray(array);
//Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
//Console.WriteLine($"Результат: {CountEvenArray(array)}");

//task 36
//void InputArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//        array[i] = new Random().Next(1,100);
//}

//int SummaOddInArray(int[] array)
//{
//    int summa = 0;
//    for (int i = 1; i< array.Length; i +=2)
//        summa = summa + array[i];
//    return summa;
//}

//Console.Clear();
//Console.Write("Введите кол-во элементов массива: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[n];
//InputArray(array);
//Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
//Console.WriteLine($"Результат: {SummaOddInArray(array)}");

//task 38
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10-1) + 1, 2);
}

double DiffMaxAndMin(double[] array)
{
    double minArray = array[0], maxArray = array[0];
    foreach (int element in array)
    {
        if (element > maxArray)
          maxArray = element;
        if (element < minArray)
          minArray = element;
    }
    return maxArray - minArray;   
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {DiffMaxAndMin(array)}");