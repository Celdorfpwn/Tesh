using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractParserLayer
{
    public interface IWpfParser
    {
        /// <summary>
        /// Parses a form designer.cs to a wpf xaml 
        /// </summary>
        /// <param name="formDesigner">Form designer.cs file</param>
        /// <param name="formXaml">Xaml output</param>
        void ParseToWpf(string formDesigner, string formXaml);
    }
}
