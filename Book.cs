using System;
using System.Collections.Generic;
using System.Text;

namespace CsFundamentals
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        private string atributoPrivado;
        public static string testeAtributoEstatico = "esse é um atributo estático que pertence a classe Book";

        public Book(string title, string author, int pages, string atributoPrivado)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            AtributoPrivado = atributoPrivado;
        }

        public virtual bool IsLongBook()
        {
            if(pages >= 500)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string AtributoPrivado
        {
            get { return atributoPrivado; }

            set
            {
                if(value != "errado")
                {
                    atributoPrivado = value;
                }
                else
                {
                    atributoPrivado = "padrão";
                }
            }
        }

    }
}
