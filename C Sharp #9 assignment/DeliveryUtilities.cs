using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace C_Sharp__9_assignment
{
    internal static class DeliveryUtilities
    {
        public static void PrintSeperator()
        {
            Console.WriteLine(new string('-', 30));
        }
        public static void PrintSystemTitle()
        {
            PrintSeperator();
            Console.WriteLine(DeliveryCenter.CenterName);
            PrintSeperator();
        }
    }
}
