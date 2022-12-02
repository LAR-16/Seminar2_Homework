Console.Clear();

Console.Write("Введите число: ");
string? b = Console.ReadLine();

int x = Int32.Parse(b);
if (x < 100) 
    Console.WriteLine("Третьей цифры нет");
else
    Console.WriteLine(Convert.ToInt32(b[2].ToString()));

