﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLib
{
    class QLibSimple
    {
        public static string name = "QLibSimple";
        public static bool usingQLibSimple = false;

       public string write(string text)
       {

            return text;
       }

        public void save_txt(string path, Dictionary<int, string> strings, Dictionary<int, int> ints)
        {

            //string path = @"data.txt";  @ - sciesszka do pliku
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

            streamWriter.WriteLine("strs: " + strings); // zapisujemy do pliku
            streamWriter.WriteLine("ints: " + ints);

            streamWriter.Close(); // zamykamy plik
        }

        public void load_txt(string path)
        {
            StreamReader streamReader = File.OpenText(path);

            string data = "";
            int i = 1;

            Console.WriteLine("\n Zawartość pliku...");
            while ((data = streamReader.ReadLine()) != null) // != null - dopuki nie napotka pustej linii
            {
                Console.WriteLine(i++ + " - " + data);
            }

            streamReader.Close();
        }
    }
}