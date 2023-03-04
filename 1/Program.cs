//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3д пространстве.

Console.Clear();
int x1 = InputNumber("Введите x1: ");
int x2 = InputNumber("Введите x2: ");
int y1 = InputNumber("Введите y1: ");
int y2 = InputNumber("Введите y2: ");
int z1 = InputNumber("Введите z1: ");
int z2 = InputNumber("Введите z2: ");

Console.WriteLine($"Расстояние между точками({x1}, {x2}, {y1}, {y2}, {z1}, {z2}) {CalculateDistance(x1, x2, y1, y2, z1, z2)}");

static int InputNumber(string message)
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? ""));
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}
static double CalculateDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + (Math.Pow(y1 - y2, 2)) + (Math.Pow(z1 - z2, 2)));
}