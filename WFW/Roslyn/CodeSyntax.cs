using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roslyn
{
    public class CodeSyntax
    {
        public NamespaceDeclarationSyntax Namespace { get; private set; }

        public ClassDeclarationSyntax ProgramDeclaration { get; private set; }

        public IEnumerable<FieldDeclarationSyntax> Fields { get; private set; }

        public CodeSyntax(string path)
        {
            var file = File.ReadAllText(path);
            SyntaxTree tree = CSharpSyntaxTree.ParseText(file);
            var root = (CompilationUnitSyntax)tree.GetRoot();
            var firstMember = root.Members[0];
            Namespace = (NamespaceDeclarationSyntax)firstMember;
            ProgramDeclaration = (ClassDeclarationSyntax)Namespace.Members[0];
            var fields = ProgramDeclaration.Members.Where(member => member is FieldDeclarationSyntax).Skip(1);
            var declarationFields = new List<FieldDeclarationSyntax>();
            foreach(var field in fields)
            {
                declarationFields.Add(field as FieldDeclarationSyntax);
            }
            Fields = declarationFields;
        }


        public IEnumerable<string> FieldNames
        {
            get
            {
                List<string> list = new List<string>();
                Fields.Skip(1).ToList()
                    .ForEach(member => list.Add(member.Declaration.Variables.First().ToFullString()));
                return list;
            }
        }

    }
}
