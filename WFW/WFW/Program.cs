using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;
using WpfParser;

namespace WFW
{
    class Program
    {
        private static string WinPath = "D:/TestingW2W/Form1.designer.cs";
        private static string WpfPath = "D:/TestingW2W/testFile.xaml";
        public static void Main(string[] args)
        {

            Wpf.Win2Wpf(WinPath, WpfPath);

            Console.WriteLine("Done...");
            Console.ReadKey();
        }


    }
}