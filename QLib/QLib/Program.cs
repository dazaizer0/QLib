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

            Dictionary<int, int> ints = new Dictionary<int, int>();
            int ile_int = 0;

            Dictionary<int, string> strings = new Dictionary<int, string>();
            int ile_str = 0;

            commends.Clear();
            start:

            Console.WriteLine();
            commends.Clear();

            int line = 0;
            var commend = "";

            foreach (var item in ints)
            {
                Console.Write(item.Key + ": ints: " + item.Value + ", ");
            }
            foreach (var item in strings)
            {
                Console.Write(item.Key + ": strings: " + item.Value + ", ");
            }

            commend = Console.ReadLine();
            commends.Add(commend);

            Console.Clear();
            for (int i = 0; i < commends.Count; i++)
            {
                Console.Write(commends[i] + ".");
            }

            if (commends[0] == "sum")
            {
                commend = Console.ReadLine();
                commends.Add(commend);

                if (commends[1] == "int")
                {
                    Console.Write("while.");
                    commend = Console.ReadLine();
                    commends.Add(commend);

                    int ile = int.Parse(commends[2]);
                    int[] indexs = new int[ile];
                    int suma = 0;

                    for (int i = 0; i < ile; i++)
                    {
                        Console.Write("int index: ");

                        commend = Console.ReadLine();
                        indexs[i] = int.Parse(commend);

                        suma += ints[indexs[i]];

                    }

                    Console.WriteLine(suma);

                    Console.Write("?save.");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "true":
                            ile_int += 1;
                            ints.Add(ile_int, suma);
                            goto start;

                        case "false":
                            goto start;

                        default:
                            goto start;
                    }
                }

                if (commends[1] == "str")
                {
                    Console.Write("while.");
                    commend = Console.ReadLine();
                    commends.Add(commend);

                    int ile = int.Parse(commends[2]);

                    int indx;
                    string suma = "";

                    for (int i = 0; i < ile; i++)
                    {
                        Console.Write("int index: ");

                        commend = Console.ReadLine();
                        indx = int.Parse(commend);

                        suma += strings[indx];

                    }
                    Console.WriteLine(suma);

                    Console.Write("?save.");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "true":
                            ile_str += 1;
                            strings.Add(ile_str, suma);
                            goto start;

                        case "false":
                            goto start;

                        default:
                            goto start;
                    }
                }

            }

            if (commends[0] == "add")
            {
                commend = Console.ReadLine();
                commends.Add(commend);

                if (commends[1] == "str")
                {
                    commend = Console.ReadLine();
                    commends.Add(commend);

                    ile_str += 1;
                    strings.Add(ile_str, commends[2].ToString());

                    Console.Clear();
                    goto start;
                }

                if (commends[1] == "int")
                {
                    commend = Console.ReadLine();
                    commends.Add(commend);

                    ile_int += 1;
                    ints.Add(ile_int, int.Parse(commends[2]));

                    Console.Clear();
                    goto start;
                }
            }

            line += 1;
            goto start;
        }
    }
}
