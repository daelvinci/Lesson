using System;
using System.Net.Mail;
using System.Threading;

namespace Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            object obj = new object();
            string est=" s";

            Console.WriteLine((est.GetType()));
            WeekDays day = WeekDays.Monday;

            //Elvin elis = new Elvin();
            Console.WriteLine(gettype(day));
            //Console.WriteLine(elis.GetType());
            foreach (var item in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(item+ "-" + (byte)item);
            }
            var array = Enum.GetValues(typeof(WeekDays));

            foreach( var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Input daxil edin");

            var input = Console.ReadLine();

            var dayobj = Enum.Parse(typeof(WeekDays), input);

            Console.WriteLine(dayobj+"-"+(byte)dayobj);

            byte dayNum = 192;
            Enum.TryParse(typeof(WeekDays), dayNum, out dayobj);
            var dayvar = (WeekDays)dayNum;
            Console.WriteLine(dayvar);

            Console.WriteLine(Enum.IsDefined(typeof(WeekDays), dayNum));
        }

        static public string gettype(object obj)
        {
            return obj.ToString();
        }
    }
}
