/*
 * Project : A3 starter
 * File : Program.cs
 * Description : This file contains code to start A3Client.exe.
 *               This project is made by taking help from http://forum.ragezone.com/f98/
 */
using System;
using System.Diagnostics;

namespace A3_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creates process
                Process a3Start = new Process();
                // Assigns the exe name to start
                a3Start.StartInfo.FileName = "A3Client.exe";
                // Parameter needed to start A3Client.exe
                a3Start.StartInfo.Arguments = "3216473353";
                // Starts exe mentioned above
                a3Start.Start();
                // Exits this application.
                Environment.Exit(0);
            }
            catch
            {
                // Exits this application.
                Environment.Exit(0);
            }
        }
    }
}
