class GetNumbers
{
    public void GetTheNumbers()
    {
        string num;
        int number;
        int i = 1;

        Console.Clear();
        Console.WriteLine("\nContinue entering numbers. Enter 'q' to exit\n");
        
        while (true)
        {
            Console.Write($"Number {i}: "); num = Console.ReadLine();
            number = Methods.IsItIntegerOrQ(num);
            if (number==000) // if the num is 'q'
            {
                break;
            }
            IntList.IntegerList.Add(number);

            i++;
        }
    }
}