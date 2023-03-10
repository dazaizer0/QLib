#region QLibBasic
#region using

// QLibBasic
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
#endregion

namespace QLib
{
    #region program
    class Program
    {
        static void Main(string[] args)
        {
            #region data

            List<string> commends = new List<string>();

            List<string> usingLib = new List<string>()
            {
                "calc.lib"
            };

            Dictionary<int, int> ints = new Dictionary<int, int>();
            int ile_int = 0;

            Dictionary<int, string> strings = new Dictionary<int, string>();
            int ile_str = 0;

            #endregion

            #region main-stream
            start:

            Console.Clear();
            Console.WriteLine();

            foreach (var item in usingLib)
            {
                Console.WriteLine("Using: " + item + "; ");
            }
            commends.Clear();

            int line = 0;
            var commend = "";

            foreach (var item in ints)
            {
                Console.Write(item.Key + ". ints >> " + item.Value + "| ");
            }
            foreach (var item in strings)
            {
                Console.Write(item.Key + ". strings >> " + item.Value + "| ");
            }

            commend = Console.ReadLine();
            commends.Add(commend);

            Console.Clear();
            for (int i = 0; i < commends.Count; i++)
            {
                Console.Write(commends[i] + ".");
            }
            #endregion

            #region sum()
            if (commends[0] == "sum()")
            {
                sum:
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
                }else
                {
                    goto sum;
                }

            }
            #endregion

            #region add()
            if (commends[0] == "add()")
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
            #endregion

            #region if
            if (commends[0] == "?ask")
            {
                commend = Console.ReadLine();
                commends.Add(commend);

                if (commends[1] == "=int")
                {

                    commend = Console.ReadLine();
                    int int_index_one = int.Parse(commend);

                    commend = Console.ReadLine();
                    int int_index_two = int.Parse(commend);

                    if (ints[int_index_one] == ints[int_index_two])
                    {

                        Console.WriteLine("true");
                    }else
                    {

                        Console.WriteLine("false");
                    }
                }

                if (commends[1] == ">int")
                {

                    commend = Console.ReadLine();
                    int int_index_one = int.Parse(commend);

                    commend = Console.ReadLine();
                    int int_index_two = int.Parse(commend);

                    if (ints[int_index_one] == ints[int_index_two])
                    {

                        Console.WriteLine("true");
                    }else
                    {

                        Console.WriteLine("false");
                    }
                }

                if (commends[1] == "<int")
                {

                    commend = Console.ReadLine();
                    int int_index_one = int.Parse(commend);

                    commend = Console.ReadLine();
                    int int_index_two = int.Parse(commend);

                    if (ints[int_index_one] == ints[int_index_two])
                    {

                        Console.WriteLine("true");
                    }else
                    {

                        Console.WriteLine("false");
                    }
                }

                if (commends[1] == "str")
                {

                    commend = Console.ReadLine();
                    int int_index_one = int.Parse(commend);

                    commend = Console.ReadLine();
                    int int_index_two = int.Parse(commend);

                    if (strings[int_index_one] == strings[int_index_two])
                    {

                        Console.WriteLine("true");
                    }else
                    {

                        Console.WriteLine("false");
                    }

                }
            }
            #endregion

            #region rev()

            if (commends[0] == "rev()")
            {

                commend = Console.ReadLine();
                commends.Add(commend);

                if (commends[1] == "str")
                {

                    Console.Write("index.");
                    commend = Console.ReadLine();

                    int rev_indx = int.Parse(commend);
                    string to_reverse = strings[rev_indx];

                    char[] cArray = to_reverse.ToCharArray();
                    string reversed = String.Empty;

                    for (int i = cArray.Length - 1; i > -1; i--)
                    {

                        reversed += cArray[i];
                    }

                    Console.WriteLine(reversed);

                    Console.Write("?save.");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {

                        case "true":
                            ile_str += 1;
                            strings.Add(ile_str, reversed);
                            goto start;

                        case "false":
                            goto start;

                        default:
                            goto start;
                    }
                }
            }

            #endregion

            #region addLib

            if (commends[0] == "addLib()")
            {

                commend = Console.ReadLine();
                commends.Add(commend);

                if (commends[1] == "vanilla")
                {

                    commend = Console.ReadLine();
                    commends.Add(commend);

                    if (commends[2] == "QLibSimple")
                    {

                        QLibSimple qLibSimple = new QLibSimple();
                        QLibSimple.usingQLibSimple = true;
                        usingLib.Add(QLibSimple.name);
                        goto start;
                    }
                }
            }

            #endregion

            #region rand()

            if (commends[0] == "rand()")
            {

                commend = Console.ReadLine();
                int od_ = int.Parse(commend);

                commend = Console.ReadLine();
                int do_ = int.Parse(commend);

                Random random = new Random();
                int randnr = random.Next(od_, do_);
                Console.WriteLine(randnr);

                Console.Write("?save.");
                var choice = Console.ReadLine();

                switch (choice)
                {

                    case "true":
                        ile_int += 1;
                        ints.Add(ile_int, randnr);
                        goto start;

                    case "false":
                        goto start;

                    default:
                        goto start;
                }
            }
            #endregion

            #region write
            if (commends[0] == "write")
            {

                commend = Console.ReadLine();
                commends.Add(commend);

                if (commends[1] == "vanilla")
                {

                    commend = Console.ReadLine();
                    commends.Add(commend);

                    if (commends[2] == "QLibSimple")
                    {

                        Console.Write(" > ");
                        var text = Console.ReadLine();

                        QLibSimple qLibSimple = new QLibSimple();
                        QLibSimple.usingQLibSimple = true;
                        usingLib.Add(QLibSimple.name);

                        Console.WriteLine(qLibSimple.write(text));
                    }

                    if (commends[2] == "variable")
                    {

                        variable:
                        Console.Write(" > ");
                        var text = Console.ReadLine();

                        try
                        {

                            int indx = int.Parse(text);

                            QLibSimple qLibSimple = new QLibSimple();
                            QLibSimple.usingQLibSimple = true;
                            usingLib.Add(QLibSimple.name);


                            Console.WriteLine(qLibSimple.write(strings[indx]));
                        }catch
                        {

                            Console.WriteLine("erroe");
                            goto variable;
                        }
                    }
                }
            }
            #endregion

            #region for
            if (commends[0] == "for")
            {

                start_for:

                Console.WriteLine("multiple(2):");
                commend = Console.ReadLine();

                int howmany = int.Parse(commend);

                Console.WriteLine("for: ");
                var for_var = Console.ReadLine();

                commend = Console.ReadLine();
                commends.Add(commend);

                if (commends[1] == "from")
                {

                    Console.WriteLine("from: ");
                    var from_var = Console.ReadLine();

                    commend = Console.ReadLine();
                    commends.Add(commend);

                    if (commends[2] == "how")
                    {

                        Console.WriteLine("how: ");
                        var how_var = Console.ReadLine();

                        commend = Console.ReadLine();
                        commends.Add(commend);

                        if (commends[3] == "what")
                        {

                            int forint = int.Parse(for_var);
                            int fromint = int.Parse(from_var);
                            int howint = int.Parse(how_var);

                            Console.WriteLine("for {  }: ");
                            var choice = Console.ReadLine();

                            if (choice == "write.vanilla.QLibSimple")
                            {

                                QLibSimple qLib = new QLibSimple();
                                QLibSimple.usingQLibSimple = true;
                                usingLib.Add(QLibSimple.name);

                                Console.WriteLine("in write: ");
                                var what = Console.ReadLine();

                                for (int i = fromint; i < forint; i += howint)
                                {

                                    Console.WriteLine(qLib.write(what));
                                }
                            }

                            if (choice == "i")
                            {

                                for (int i = fromint; i < forint; i += howint)
                                {

                                    Console.WriteLine(i);
                                }
                            }

                            if (choice == "sium()")
                            {

                                Console.WriteLine("to sum: ");
                                var what = Console.ReadLine();

                                int what_int = int.Parse(what);

                                for (int i = fromint; i < forint; i += howint)
                                {

                                    try
                                    {
                                        Console.WriteLine(ints[what_int] * i);
                                    }catch
                                    {
                                        Console.WriteLine("error 404");
                                        Thread.Sleep(500);
                                        goto start_for;
                                    }
                                }
                            }

                            if (howmany > 1 && choice == "multiple")
                            {

                                for (int i = fromint; i < forint; i += howint)
                                {

                                    for (int j = fromint; j < forint; j += howint)
                                    {

                                        Console.Write(" *");
                                    }

                                    Console.WriteLine();
                                }
                            }


                            if (choice == "variable")
                            {

                                Console.WriteLine("variable: ");
                                var what = Console.ReadLine();

                                try
                                {
                                    int what_int = int.Parse(what);

                                    for (int i = fromint; i < forint; i += howint)
                                    {

                                        Console.WriteLine(ints[what_int]);
                                    }
                                }catch
                                {

                                    Console.WriteLine("error");
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region txt.files
            if (commends[0] == "QLibSimple(txt)")
            {

                //Console.WriteLine("in development"); goto finish;

                QLibSimple qLibSimple = new QLibSimple();
                QLibSimple.usingQLibSimple = true;
                usingLib.Add(QLibSimple.name);

                /*Console.WriteLine("path: ");*/

                commend = Console.ReadLine();
                commends.Add(commend);

                string path  = @"data.txt"; 


                if (commends[1] == "save")
                {

                    commend = Console.ReadLine();
                    commends.Add(commend);

                    if (commends[2] == "str")
                    {

                        commend = Console.ReadLine();
                        commends.Add(commend);

                        int indToSave = int.Parse(commend);

                        StreamWriter streamWriter;

                        if (!File.Exists(path))
                        {

                            streamWriter = File.CreateText(path); // tworzymy plik
                            Console.WriteLine("\n File have created...");
                        }
                        else
                        {

                            streamWriter = new StreamWriter(path, true); // append = true - dołacz, faalse != append = zapisuje na nowo
                            Console.WriteLine("\n File have opened...");
                        }

                        streamWriter.WriteLine(/*"string: " + */ strings[indToSave]); // zapisujemy do pliku

                        streamWriter.Close(); // zamykamy plik

                    }
                    else if (commends[2] == "int")
                    {

                        commend = Console.ReadLine();
                        commends.Add(commend);

                        int indToSave = int.Parse(commend);

                        StreamWriter streamWriter;

                        if (!File.Exists(path))
                        {

                            streamWriter = File.CreateText(path); // tworzymy plik
                            Console.WriteLine("\n File have created...");
                        }
                        else
                        {

                            streamWriter = new StreamWriter(path, true); // append = true - dołacz, faalse != append = zapisuje na nowo
                            Console.WriteLine("\n File have opened...");
                        }

                        streamWriter.WriteLine(/*"int: " + */ ints[indToSave]); // zapisujemy do pliku

                        streamWriter.Close(); // zamykamy plik
                    }
                } else if (commends[1] == "load")
                {

                    StreamReader streamReader = File.OpenText(path);

                    string data = "";
                    int i = 1;

                    Console.WriteLine("\n Zawartość pliku...");

                    while ((data = streamReader.ReadLine()) != null) // != null - dopuki nie napotka pustej linii
                    {

                        whileP:

                        Console.WriteLine(i++ + " - " + data);

                        Console.Write("?save.");
                        var choice = Console.ReadLine();

                        if(choice == "true")
                        {

                            Console.WriteLine("int or str.");
                            commend = Console.ReadLine();
                            commends.Add(commend);

                            if (commend == "int")
                            {

                                ile_int += 1;

                                int data_int = int.Parse(data);
                                ints.Add(ile_int, data_int);
                            }
                            else
                            {

                                ile_str += 1;
                                strings.Add(ile_str, data);
                            }
                        }
                        else
                        {

                        }
                    }
                    streamReader.Close();
                }
            }
            #endregion

            #region while

            if (commends[0] == "while")
            {

                commend = Console.ReadLine();

                int while_int = int.Parse(commend);

                Console.Write("do.");
                commend = Console.ReadLine();
                commends.Add(commend);

                if (commends[1] == "write")
                {

                    Console.Clear();
                    Console.Write("while.do.write(lib).");

                    commend = Console.ReadLine();
                    commends.Add(commend);

                    if (commends[2] == "QLibSimple")
                    {

                        QLibSimple qLib = new QLibSimple();
                        QLibSimple.usingQLibSimple = true;
                        usingLib.Add(QLibSimple.name);

                        Console.Clear();
                        Console.Write("while.do.write(QLibSimple).(text)");
                        commend = Console.ReadLine();

                        string what = commend;

                        int i = 0;
                        while(i != while_int)
                        {

                            Console.WriteLine(qLib.write(what));
                            i++;
                        }
                    }

                }else if (commends[1] == "i")
                {

                    int i = 0;
                    while( i != while_int)
                    {

                        Console.WriteLine(i);
                        i++;
                    }

                } else if (commends[1] == "variable")
                {

                    try
                    {

                        Console.WriteLine("variable.");
                        var what = Console.ReadLine();

                        int int_index = int.Parse(what);

                        try
                        {

                            int what_int = int.Parse(what);
                            int i = 0;
                            while (i != while_int)
                            {
                                Console.WriteLine(ints[int_index]);
                                i++;
                            }
                        }catch
                        {
                            Console.WriteLine("error");
                        }

                    }catch
                    {
                        Console.WriteLine("error");
                    }

                }else
                {
                    goto start;
                }
            }

            #endregion

            #region finish
            finish:

            Console.Write("return> ");
            var end = Console.ReadLine();

            switch (end)
            {

                case "return":
                    Thread.Sleep(100); Console.Write(".");

                    line += 1;
                    goto start;

                case "return.vanilla.QLibSimple":
                    QLibSimple qLibSimple = new QLibSimple();
                    QLibSimple.usingQLibSimple = true;
                    usingLib.Add(QLibSimple.name);

                    Thread.Sleep(100); Console.Write(".");

                    line += 1;
                    goto start;

                default:
                    Console.Write("returning");
                    Thread.Sleep(100); Console.Write(".");
                    Thread.Sleep(100); Console.Write(".");
                    Thread.Sleep(100); Console.Write(".");

                    line += 1;
                    goto start;
            }
            #endregion
        }
    }
    #endregion
}
#endregion
