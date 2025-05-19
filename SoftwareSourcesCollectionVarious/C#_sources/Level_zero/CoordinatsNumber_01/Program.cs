/*
Задача №2: Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
в которой находится эта точка.
*/

Console.WriteLine("Описание программы:");
Console.WriteLine("Программа принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.\n");

Console.WriteLine("Введите координаты точки (X,Y): ");

int CoordX = 0;
while (CoordX == 0)
{
    Console.Write("Введите координату X: ");
    CoordX = Convert.ToInt32(Console.ReadLine());
    if (CoordX == 0)
    {
        Console.WriteLine("Ошибка. Координата X = 0. Повторите ввод.");
    }
}


int CoordY = 0;
while (CoordY == 0)
{
    Console.Write("Введите координату Y: ");
    CoordY = Convert.ToInt32(Console.ReadLine());
    if (CoordY == 0)
    {
        Console.WriteLine("Ошибка. Координата Y = 0. Повторите ввод.");
    }
}

if (CoordX > 0 && CoordY > 0)
{
    Console.WriteLine($"Точка с координатами ({CoordX},{CoordY}) находится в I-ой координатной плоскости.");
}
else if (CoordX > 0 && CoordY < 0)
{
    Console.WriteLine($"Точка с координатами ({CoordX},{CoordY}) находится в IV-ой координатной плоскости.");    
}
else if (CoordX < 0 && CoordY > 0)
{
    Console.WriteLine($"Точка с координатами ({CoordX},{CoordY}) находится во II-ой координатной плоскости.");
}
else if (CoordX < 0 && CoordY < 0)
{
    Console.WriteLine($"Точка с координатами ({CoordX},{CoordY}) находится в III-ей координатной плоскости.");
}
