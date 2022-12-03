Console.Clear();

Console.WriteLine("Введите последовательность чисел: ");

int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
int max2 = 0;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
      
        if (n > max) 
        {
        max2 = max;
        max = n;
        }
        else if (n < max && n > max2)
        {
        max2 = n;
        }
           
}

Console.WriteLine("end"); 
Console.WriteLine(" ");
Console.WriteLine($"Второе максимальное число - {max2}");


