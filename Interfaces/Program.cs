using Interfaces;

Car ford = new Car("Ford", 2010, 70);
Console.WriteLine(ford);
ford.Print();
ford.Go();
Console.WriteLine();

Plane boeing = new("Boeing", 2000, 900, 40);
Console.WriteLine(boeing);
boeing.Print(); // склеивание
((IGo)boeing).Print();// кастинг
boeing.IFlyPrint();// обертывние
boeing.Go();
boeing.Fly();
Console.WriteLine();

IGo[] go = new IGo[]
{
    ford, new Car(), new Car("Запорожец", 1950, 50), new Car("WV", 1990, 75),
    boeing, new Plane(), new Plane("Ил-2", 1943, 300, 40), new Plane("Airbus", 2015, 990, 60)
};
foreach (IGo g in go)
{
    Console.WriteLine(g);
    (g as IFly)?.Fly();
}

Console.WriteLine("\nСоздан массив:");
Plane[] planes = new Plane[]
{
    boeing, new Plane(), new Plane("Ил-2", 1943, 300, 40), new Plane("Airbus", 2015, 990, 60),
    new Plane("F-22 Raptor", 2019, 1900, 120), new Plane ("Ан-76", 1970, 870, 50)
};
foreach (Plane i in planes)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nСортировка по названиям:");
Array.Sort(planes);
foreach (Plane i in planes)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nСортировка по году выпуска");
Array.Sort(planes, new Plane().Compare);
foreach (var i in planes)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nСортировка по скорости полета");
Array.Sort(planes, new Plane().CompareSecond);
foreach (var i in planes)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nВывод квадратов чисел от 2 до 5 (включительно)");
Squares squares = new();
foreach (var i in squares.Numbers(2, 5))
{
    Console.Write($"{i}\t");
}
