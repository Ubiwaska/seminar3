// Программа, которая принимает на вход пятизначное число, и показывает палиндром ли оно
Console.Clear();
int n;
while (true)
{
    Console.WriteLine("Enter a 5-digit integer number");

    if (int.TryParse(Console.ReadLine(), out n))
    {
        int a1 = n / 10000;

        if (a1 == 0)
        {
            Console.WriteLine("Error: The entered integer number has less than 5 digits.");
        }
        else if (a1 > 9)
        {
            Console.WriteLine("Error: The entered integer number has more than 5 digits.");
        }
        else
        {
            int a5 = n % 10;
            if (a1 == a5)
            {
                int a2 = n % 10000 / 1000;
                int a4 = (n % 100 - a5) / 10;

                if (a2 == a4)
                {
                    Console.WriteLine("The entered integer number IS a polyndrom.");
                }
                else
                {
                    Console.WriteLine("The entered integer number IS NOT a polyndrom.");
                }
            }
            else
            {
                Console.WriteLine("The entered integer number IS NOT a polyndrom.");
            }

            break;
        }

    }
    else
    {
        Console.WriteLine("Error!: An integer number was not entered");
    }
}

