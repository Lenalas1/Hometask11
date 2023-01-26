
//task 10
//Console.Clear();
//Console.Write("Введите 3х значное число ");
//int n = Convert.ToInt32(Console.ReadLine());
//int n2 = ( n % 100) / 10;
//Console.WriteLine(n2);

//task13
//Console.Clear();
//Console.Write("Введите число ");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n < 100)
//    Console.WriteLine("Нет третьей цифры ");
//else
//{
//    while (n >= 1000 )
//    {
//        n = n /10;
//    }
//    Console.WriteLine(n);
//    Console.WriteLine(n % 10);
//}

//task15
//Console.Clear();
//Console.Write("Введите число, обозначающее день недели ");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n >= 6)
//    Console.WriteLine( "Да, это выходной");
//if (n < 6)
//    Console.WriteLine("Нет, это рабочий день");

//additional tsk
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine()), max1 = n, max2 = 0;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max1)
    {
        max2 = max1;
        max1 = n;
    }
    else if (n > max2)
        max2 = n;
} 
Console.WriteLine(max2);
