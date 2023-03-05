using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLib
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commends = new List<string>();

            Queue<int> ints = new Queue<int>();
            Queue<string> strings = new Queue<string>();

            commends.Clear();
            start:
            commends.Clear();

            int line = 0;
            var commend = "";

            foreach (var item in ints)
            {
                Console.Write(ints.ToArray().ToList().IndexOf(item) + ": ints: " + item + ", ");
            }
            foreach (var item in strings)
            {
                Console.Write(strings.ToArray().ToList().IndexOf(item) + ": strings: " + item + ", ");
            }

            commend = Console.ReadLine();
            commends.Add(commend);

            Console.Clear();
            for (int i = 0; i < commends.Count; i++)
            {
                Console.Write(commends[i] + ".");
            }

            if(commends[0] == "add")
            {
                commend = Console.ReadLine();
                commends.Add(commend);

                if (commends[1] == "str")
                {
                    commend = Console.ReadLine();
                    commends.Add(commend);

                    strings.Enqueue(commends[2].ToString());

                    Console.Clear();
                    goto start;
                }

                if (commends[1] == "int")
                {
                    commend = Console.ReadLine();
                    commends.Add(commend);

                    ints.Enqueue(int.Parse(commends[2]));

                    Console.Clear();
                    goto start;
                }
            }

            line += 1;
            goto start;
        }
    }
}
