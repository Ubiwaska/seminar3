Console.Clear();
int n;
while (true)
{
    Console.WriteLine("Enter a postive integer number:");

    if (int.TryParse(Console.ReadLine(), out n))
    {

        if (n > 0)
        {
            Console.Write(n + "->1");
            for (int i = 2; i <= n; i++)
            {
                Console.Write("," + Math.Pow(i, 3));
            }
            Console.WriteLine("");
            break;
        }
        else
        {
            Console.WriteLine("Error!: The entered integer must be postive!");
        }
    }
    else
    {
        Console.WriteLine("Error!: An integer number was not entered");
    }
}