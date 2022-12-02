Console.Clear();

Console.Write("Введите трехзначное число: ");
string? b = Console.ReadLine();

int x = Int32.Parse(b); 
if (x > 99 && x < 1000)
    Console.WriteLine(Convert.ToInt32(b[1].ToString()));

else 
    Console.WriteLine("Число неверное");


