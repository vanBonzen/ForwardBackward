using System;
using ForwardBackward.Tools;

namespace ForwardBackward
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Program.ForwardBackward(100);
            Program.ForwardBackward(100000);
        }

        private static void ForwardBackward(int iterations)
        {
            int result = 0;
            result = Program.RollXTimes(iterations);
            Program.OutputResult(result, iterations);
        }
        
        private static int RollXTimes(int rolls)
        {
            Dice dice = Dice.Instance;
            int result = 0;
            
            for (var i = 0; i < rolls; i++)
            {
                if (i % 2 == 0)
                {
                    result += dice.Roll;
                }
                else
                {
                    result -= dice.Roll;
                }
            }
            return result;
        }
        
        private static void OutputResult(int result, int numberOfRolls)
        {
            Console.Write("Position at " + numberOfRolls + " rolls: ");
            Console.WriteLine(result);
        }
    }
}