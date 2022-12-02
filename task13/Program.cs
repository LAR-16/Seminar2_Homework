Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 99)
{
int x = n % 1000;
Console.WriteLine(x);
Console.WriteLine(x/100);

}
else
{
  Console.WriteLine("Третьей цифры нет");  
}



