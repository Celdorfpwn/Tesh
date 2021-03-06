﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfParser
{
    internal class XamlDocument : XmlDocument
    {

        private WindowAttributesFactory WindowAttributesFactory { get; set; }

        private string WinForm { get; set; }

        private string WpfXaml { get; set; }

        private CodeSyntax CodeSyntax { get; set; }

        public XamlDocument(string winForm,string wpfXaml)
        {
            WinForm = winForm;
            WpfXaml = wpfXaml;
            CodeSyntax = new CodeSyntax(winForm);
            WindowAttributesFactory = new WindowAttributesFactory(this);
        }

        public void CreateXaml()
        {
            CreateWindowNode();
        }

        private void CreateWindowNode()
        {
            var layout = new List<string> { "ResumeLayout", "SuspendLayout" };
            var fieldNames = CodeSyntax.FieldNames;
            var filterLines = File.ReadAllLines(WinForm).Where(line => line.Contains("this."))
                .Where(line => !line.ContainsOneFromList(fieldNames))
                .Where(line => !line.ContainsOneFromList(layout));

            XmlNode node = this.CreateElement(Xaml.Window, Xaml.WindowUri);
            XmlAttribute xClassAttribute = this.CreateAttribute(Xaml.WindowClassPrefix, Xaml.WindowClass,Xaml.WindowClassUri);
            xClassAttribute.Value = new StringBuilder()
                .Append(CodeSyntax.Namespace.Name)
                .Append(".")
                .Append(CodeSyntax.ProgramDeclaration.Identifier.ToString()).ToString();
            node.Attributes.Append(xClassAttribute);

            var attributes = WindowAttributesFactory.GetWindowAttributes(filterLines);

            foreach(var attribute in attributes)
            {
                node.Attributes.Append(attribute);
            }

            this.AppendChild(node);
            XmlNode grid = this.CreateElement(Xaml.Grid, this.DocumentElement.NamespaceURI);

            XmlNode canvas = this.CreateElement(Xaml.Canvas, this.DocumentElement.NamespaceURI);
            grid.AppendChild(canvas);

            node.AppendChild(grid);

            var controlsLines = File.ReadAllLines(WinForm).ToList();

            ProcessLines(controlsLines);


            var controls = XamlContainerFactory.XamlContainerFactory.GetContainers(controlsLines, this, CodeSyntax.Fields).ToList();

            foreach (XmlNode control in controls)
            {
                canvas.AppendChild(control);
            }
        }

        private void ProcessLines(List<string> controlsLines)
        {
            var specialLine = controlsLines.FirstOrDefault(line => line.Trim().StartsWith("|"));

            while(specialLine!=null)
            {
                var index = controlsLines.IndexOf(specialLine);
                controlsLines[index - 1] += controlsLines[index];
                controlsLines.RemoveAt(index);
                specialLine = controlsLines.FirstOrDefault(line => line.Trim().StartsWith("|"));
            }
        }

        public void SaveXaml()
        {
            this.Save(WpfXaml);
        }


    }
}
