using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "ABc";
            int* p = (int*)malloc(sizeof(int) * 4);
            int i;

            // p[] contains some garbage value so 
            // below loop does not make any sense. 
            for (i = 0; i < 4; i++)
                p[i] += 100;
        }
    }
}
