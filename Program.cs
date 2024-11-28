﻿while (true)
{
    Console.Clear();
    Methods.ShowInstructions();

    Console.WriteLine("To add numbers(1)");
    Console.WriteLine("To process numbers(2)");
    Console.WriteLine("Exit(0)");
    string reply = Console.ReadLine();

    switch (reply)
    {
        case "1":
        Methods.AddNumber();
        break;

        case "2":
        Methods.ProcessNumbers();
        break;

        case "0":
        Environment.Exit(0);
        break;

        default:
        break;
    }
}