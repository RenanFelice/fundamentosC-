using System;
using System.Collections.Generic;
using System.Text;

namespace CsFundamentals
{
    //exemplo de classe que herda a Classe Book
    internal class ClassHerdaBook : Book
    {

        public ClassHerdaBook(string title, string author, int pages, string atributoPrivado) : base(title, author, pages, atributoPrivado)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;

        }

        public override bool IsLongBook()
        {
            return false;
        }
    }
}
