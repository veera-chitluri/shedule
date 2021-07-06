using System;

namespace dividing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The first Number");
            num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter The second Number");
             num2 = Convert.ToInt32(Console.ReadLine());
             if(num2==0)
                 Console.WriteLine("Fail");
             else
                 div = num1/num2;
                 Console.WriteLine(div);

             


        }
    }
}

