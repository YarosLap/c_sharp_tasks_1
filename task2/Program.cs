Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
    Console.WriteLine($"Большее число {a}, меньшее число {b}");
else if (a < b)
    Console.WriteLine($"Большее число {b}, меньшее число {a}");
else if (a == b)
    Console.WriteLine("Числа равны");
else Console.WriteLine("Ошибка ввода");