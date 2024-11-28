using System.Drawing;

public static class Methods
{
    public static void AddNumber()
    {
        GetNumbers get = new GetNumbers();
        get.GetTheNumbers();
    }
    public static void ProcessNumbers()
    {
        Process news = new Process();
        news.ProcessNumbers(); 
    }
    public static void PrintList()
    {
        Console.WriteLine("\nReceived List:");
        Console.WriteLine(string.Join(", ", IntList.IntegerList));

        Console.WriteLine("\nThose smaller and larger than the number 67: \n");
        Console.WriteLine(string.Join(", ", IntList.Under67));
        Console.WriteLine(string.Join(", ", IntList.Over67));

        Console.WriteLine("\nProcessed List:");
        Console.WriteLine(string.Join(", ", IntList.FinishedList));

        IntList.Under67.Clear();
        IntList.Over67.Clear();
        IntList.IntegerList.Clear();
        IntList.FinishedList.Clear();
        
        Console.WriteLine("\nList cleared! Press any key to exit");
        Console.ReadKey();
    }
    public static int IsItIntegerOrQ(string num)
    {
        while (true)
        {
            if (!string.IsNullOrWhiteSpace(num) && int.TryParse(num, out int number))
            {
                return number;
            }
            if (num.ToLower()=="q")
            {
                return 000;
            }            
            Console.WriteLine("please enter a valid integer!");
            Console.Write("Try again: ");
            num = Console.ReadLine();
        }
    }
    public static void ShowInstructions()
    {
    Console.WriteLine("The operation will be performed with consecutive numbers, starting from the first element");
    Console.WriteLine("* Those less than 67 are subtracted from 67 and the differences are added.");
    Console.WriteLine("* Those greater than 67 are subtracted from 67 and the squares of the differences are added together.\n");
    }
    public static void PrintLastindex(List<int> list)
    {
        int LastIndex = list.Count-1;
        if (list.Count % 2 != 0)
        {
            Console.WriteLine($"Note: The last number has no pair and was skipped! Number: {list[LastIndex]}");
        }
    }
    public static void ProcessingNumbers()
    {
        for (int i = 0; i < IntList.Under67.Count -1; i+=2)
        {
            int thisNum = 67-IntList.Under67[i];
            int nextNum = 67-IntList.Under67[i+1];
            IntList.FinishedList.Add(thisNum+nextNum);
        }
        for (int i = 0; i < IntList.Over67.Count -1; i+=2)
        {
            int thisNum = 67-IntList.Over67[i];
            int nextNum = 67-IntList.Over67[i+1];  
            thisNum = thisNum*thisNum;
            nextNum = nextNum*nextNum;   
            IntList.FinishedList.Add(thisNum+nextNum);
        }
    }
}