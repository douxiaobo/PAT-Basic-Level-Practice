using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int step=0;
            int n=int.Parse(Console.ReadLine());
            while(n!=1)
            {
                if(n%2==1)
                    n=3*n+1;
                else
                {
                    n=n/2;
                    step++;
                }
            }
            Console.WriteLine(step);
        }
    }
}