using System;

namespace Prime 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second Number : ");
            int second = int.Parse(Console.ReadLine());
            int t = 0;
            for (int i = first; i <= second; i++)
            {
                for (int s = 1; s <= i; s++)
                {
                    if (i % s == 0)
                    {
                        t++;
                    }
                }
                    if (t == 2)
                    {
                        Console.WriteLine(i);
                        t = 0;

                    }
                    else
                        t = 0;
                }
            

        }
    }
      
       
    
}
