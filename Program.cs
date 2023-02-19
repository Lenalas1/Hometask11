//task 41
//Console.Clear();
//Console.Write("Введите число ");
//int n = Convert.ToInt32(Console.ReadLine()), count = 0;
//for (int i = 0; i < n; i++);
//{
//    Console.Write("Введите число; ");
//    int y = Convert.ToInt32(Console.ReadLine());
//    if (y > 0)
//        count++;
//}
//Console.WriteLine($"Результат: {count}");

//task 43
Console.Clear();
Console.Write("Введите число k(1): ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b(1): ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k(2): ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b(2): ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b2 -b1) / (k2 -k1);
double y = k1 * x +b1;
Console.WriteLine($"Результат: ({x}, {y})");
