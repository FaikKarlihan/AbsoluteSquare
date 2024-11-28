class Process
{
    public void ProcessNumbers() 
    {
        Console.Clear();

        if (IntList.IntegerList.Count >= 2)
        {
            foreach (int num in IntList.IntegerList)
            {
                if (num<67)
                {
                    IntList.Under67.Add(num);
                }
                else
                {
                    IntList.Over67.Add(num);
                }
            }

            Methods.ProcessingNumbers();

            Methods.PrintLastindex(IntList.Under67);
            Methods.PrintLastindex(IntList.Over67);

            Methods.PrintList();

        }
        else
        {
            Console.WriteLine("Must be at least two numbers on the list!\nPress any key to exit");
            Console.ReadKey();
        }
    }
}