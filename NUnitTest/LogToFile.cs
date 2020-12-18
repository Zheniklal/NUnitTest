using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyTestedApp
{
    class LogToFile
    {
        private static string fileName = @"C:\Users\Владелец\source\q.txt";
        public static void WriteToFile(bool state, string item)
        {
            StreamWriter streamWriter = File.AppendText(fileName);
            if (state)
            {
                streamWriter.WriteLine("Accepted: " + item);
            }
            else
            {
                streamWriter.WriteLine("Exception: " + item);
            }
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
