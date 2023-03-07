using System;

namespace ipv6_to_domain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("\n");
            for (; ; )
            {
                Console.Write("Press an IPv6 Address:");
                var addr = Console.ReadLine();
                Console.WriteLine($"-------- Domain after convert --------\n{addr.Replace(":", "-")+ ".ipv6-literal.net"}\n--------------------------------------");
            } 
        }
    }
}
