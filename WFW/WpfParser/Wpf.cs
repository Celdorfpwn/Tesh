using Roslyn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfParser
{
    public static class Wpf
    {

        /// <summary>
        /// Parse a WinForms Form to a Wpf xaml
        /// </summary>
        /// <param name="formDesignerInput">The designer.cs from a form</param>
        /// <param name="wpfXamlOutput">The wpf output file</param>
        public static void Win2Wpf(string formDesignerInput,string wpfXamlOutput)
        {
            XamlDocument windowXaml = Xaml.NewXaml(formDesignerInput, wpfXamlOutput);
            windowXaml.CreateXaml();
            windowXaml.SaveXaml();
        }
    }
}
