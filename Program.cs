// task 2
//Console.Clear();
//Console.Write("Введите 1-ое число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 2-ое число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//if (n > m)
//    Console.WriteLine (n);
//else
//    Console.WriteLine (m);

// task 4
//Console.Clear();
//Console.Write("Введите 1-ое число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 2-ое число: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите 3-ое число: ");
//int s = Convert.ToInt32(Console.ReadLine()), max = n;
//if ( max < m )
//    max = m;
//if ( max < s)
//    max = s;
//Console.WriteLine(max);

//task 6
//Console.Clear();
//Console.Write("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n/2 == 0)
//    Console.WriteLine( "Четное число");
//else
//    Console.WriteLine( "Нечетное число");

//task 8
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 2;
while (count <= n)
{
    Console.WriteLine($"{count} ");
    count = count + 2;   
}
