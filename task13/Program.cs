Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99 && n < 1000)
    {
    int x = n % 10;
    Console.WriteLine(x);
    }
    else if (n >= 1000 && n < 10000)
    {
    int x = n / 10;
    Console.WriteLine(x%10);
    }
    else if (n >= 10000 && n < 100000)
    {
    int x = n / 100;
    Console.WriteLine(x%10);
    }
    else if (n >= 100000 && n < 1000000)
    {
    int x = n / 1000;
    Console.WriteLine(x%10);
    }
    else if (n >= 1000000 && n < 10000000)
    {
    int x = n / 10000;
    Console.WriteLine(x%10);
    }
    else if (n >= 10000000 && n < 100000000)
    {
    int x = n / 100000;
    Console.WriteLine(x%10);
    }
     else if (n >= 100000000 && n < 1000000000)
    {
    int x = n / 1000000;
    Console.WriteLine(x%10);
    }
    else if (n >= 1000000000 && n <= 2147483647)
    {
    int x = n / 10000000;
    Console.WriteLine(x%10);
    }

else 
{
  Console.WriteLine("Третьей цифры нет");  
}



