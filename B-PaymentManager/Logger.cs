﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PaymentManager
{
    class Logger
    {
        static string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
        static string path = (System.IO.Path.GetDirectoryName(executable))+@"\log.txt";        
       public static void WriteLog(String line) {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(line);
            }
        }

    }
}
