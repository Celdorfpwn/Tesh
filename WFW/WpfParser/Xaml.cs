using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfParser
{
    internal class Xaml
    {
        internal static XamlDocument NewXaml(string winForm,string wpfXaml)
        {
             return new XamlDocument(winForm,wpfXaml);
        }

        internal const string Window = "Window";
        internal const string WindowUri = "http://schemas.microsoft.com/winfx/2006/xaml/presentation";
        internal const string WindowClassUri = "http://schemas.microsoft.com/winfx/2006/xaml";
        internal const string WindowClass = "Class";
        internal const string WindowClassPrefix = "x";
        internal const string Grid = "Grid";
        internal const string Button = "Button";

        internal const string Canvas = "Canvas";
    }
}
