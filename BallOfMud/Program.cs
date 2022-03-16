using System;
using BallOfMud.Services;

namespace BallOfMud
{
    class Program
    {
        static void Main(string[] args)
        {
            BigClassFacade bigClass = new BigClassFacade(new BigClass());
            bigClass.IncreaseBy(50);
            bigClass.IncreaseBy(10);
            bigClass.IncreaseBy(5);
            bigClass.DecreaseBy(1);

            Console.WriteLine($"Final Number : {bigClass.GetCurrentValue()}");

            //BigClass bigClass = new BigClass();

            //bigClass.SetValueI(3);

            //bigClass.IncrementI();
            //bigClass.IncrementI();
            //bigClass.IncrementI();

            //bigClass.DecrememntI();

            //Console.WriteLine($"Final Number : {bigClass.GetValueA()}");
        }
    }
}