using System;
namespace shocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите количество денег ");
            int x = Convert.ToInt32(Console.ReadLine());            
            int y = 1;            
            int z = 3;  
            kolvo_suma123(x, y, z);
        }        
        static int  kolvo_suma123(int x, int y, int z)
        {
            if (x < y)
            {
                return 0;
            }
            int xyz = x / y;

            xyz = xyz + (xyz - 1) / (z - 1);

            Console.WriteLine("шоколадки " + xyz);

            return xyz;
        }      
    }
}
