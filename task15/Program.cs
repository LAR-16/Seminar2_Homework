Console.Clear();

int day = new Random(). Next(1, 8);
Console.Write($"день {day} - это " );
if (day >= 1 && day < 6)
    Console.WriteLine("будний день");
else
    Console.WriteLine("выходной");