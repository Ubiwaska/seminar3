//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3д пространстве.

Console.Clear();
int x1 = InputNumber("Enter x1: ");
int y1 = InputNumber("Enter y1: ");
int z1 = InputNumber("Enter z1: ");

int x2 = InputNumber("Enter x2: ");
int y2 = InputNumber("Enter y2: ");
int z2 = InputNumber("Enter z2: ");

Console.WriteLine($"The distance between points ({x1}, {y1}, {z1}) and ({x2}, {y2}, {z2}) is equal to {CalculateDistance(x1, y1, z1, x2, y2, z2)}");


static int InputNumber(string message)
{
    int coordinate;
    while (true)
    {

        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out coordinate))
        {
            return coordinate;
            break;
        }
        else
        {
            Console.WriteLine("Error!: An integer number was not entered. Try again! ");
        }

    }
}
static double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + (Math.Pow(y1 - y2, 2)) + (Math.Pow(z1 - z2, 2)));
}