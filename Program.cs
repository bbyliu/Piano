int[] octavaPlay = { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
Console.WriteLine("Переключение между октавами F5 u F6");

while (true)
{
    ConsoleKeyInfo tap = Console.ReadKey(true);

    if (tap.Key == ConsoleKey.F5)
    {
        Console.WriteLine("5 октава");
        octavaPlay = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

        switch (tap.Key)
        {
            case ConsoleKey.A:
                Console.Beep(octavaPlay[0], 200);
                break;
            case ConsoleKey.W:
                Console.Beep(octavaPlay[1], 200);
                break;
            case ConsoleKey.S:
                Console.Beep(octavaPlay[2], 200);
                break;
            case ConsoleKey.E:
                Console.Beep(octavaPlay[3], 200);
                break;
            case ConsoleKey.D:
                Console.Beep(octavaPlay[4], 200);
                break;
            case ConsoleKey.F:
                Console.Beep(octavaPlay[5], 200);
                break;
            case ConsoleKey.T:
                Console.Beep(octavaPlay[6], 200);
                break;
            case ConsoleKey.G:
                Console.Beep(octavaPlay[7], 200);
                break;
            case ConsoleKey.Y:
                Console.Beep(octavaPlay[8], 200);
                break;
            case ConsoleKey.H:
                Console.Beep(octavaPlay[9], 200);
                break;
            case ConsoleKey.U:
                Console.Beep(octavaPlay[10], 200);
                break;
            case ConsoleKey.J:
                Console.Beep(octavaPlay[11], 200);
                break;
        }

    }
    else if (tap.Key == ConsoleKey.F6)
    {
        Console.WriteLine("6 октава");
        octavaPlay = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };

        switch (tap.Key)
        {
            case ConsoleKey.A:
                Console.Beep(octavaPlay[0], 200);
                break;
            case ConsoleKey.W:
                Console.Beep(octavaPlay[1], 200);
                break;
            case ConsoleKey.S:
                Console.Beep(octavaPlay[2], 200);
                break;
            case ConsoleKey.E:
                Console.Beep(octavaPlay[3], 200);
                break;
            case ConsoleKey.D:
                Console.Beep(octavaPlay[4], 200);
                break;
            case ConsoleKey.F:
                Console.Beep(octavaPlay[5], 200);
                break;
            case ConsoleKey.T:
                Console.Beep(octavaPlay[6], 200);
                break;
            case ConsoleKey.G:
                Console.Beep(octavaPlay[7], 200);
                break;
            case ConsoleKey.Y:
                Console.Beep(octavaPlay[8], 200);
                break;
            case ConsoleKey.H:
                Console.Beep(octavaPlay[9], 200);
                break;
            case ConsoleKey.U:
                Console.Beep(octavaPlay[10], 200);
                break;
            case ConsoleKey.J:
                Console.Beep(octavaPlay[11], 200);
                break;
        }
    }
    else if (tap.Key == ConsoleKey.Escape)
    {
        Environment.Exit(0);
    }

}

