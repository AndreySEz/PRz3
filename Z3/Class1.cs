using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Book
    {
        private string authorSurname, authorName, authorPatronim, name;
        public string code;
        private int year;
        public int pages;

        public Book(string authorName, string authorPatronim, string authorSurname, string name, string code, int year, int pages)
        {
            this.authorName = authorName;
            this.authorSurname = authorSurname;
            this.authorPatronim = authorPatronim;
            this.name = name;
            this.code = code;
            this.year = year;
            this.pages = pages;
        }

        public Book()
        {

        }

        public Book(string authorName, string authorSurname, string name, string code, int year, int pages)
        {
            this.authorName = authorName;
            this.authorSurname = authorSurname;
            this.name = name;
            this.code = code;
            this.year = year;
            this.pages = pages;
        }
        public void ToString(string stroka)
        {
            if (authorPatronim != null)
                stroka = $"{authorSurname}, {authorName}, {authorPatronim}, {authorSurname}. \"{name}\". {year}. {pages} страниц. Код {code}";
        }
        public void Compare(string book1, string book2, string value)
        {
            Book firstBook = new Book();
            Book secondBook = new Book();
            foreach (Book book in bookList)
            {
                if (book.name.Equals(book1)) firstBook = book;
                if (book.name.Equals(book2)) secondBook = book;
            }

            switch (value)
            {
                case "Автор":
                    {
                        System.Windows.MessageBox.Show($"Автор первой книги: {firstBook.authorName} {firstBook.authorPatronim} {firstBook.authorSurname}; Второй: {secondBook.authorName} {secondBook.authorPatronim} {secondBook.authorSurname}");
                        break;
                    }
                case "Год":
                    {
                        System.Windows.MessageBox.Show($"Год публикации первой книги: {firstBook.year}; Второй: {secondBook.year}");
                        break;
                    }
                case "Страницы":
                    {
                        System.Windows.MessageBox.Show($"Страниц в первой книге: {firstBook.pages}; Во второй: {secondBook.pages}");
                        break;
                    }
            }
        }
        List<Book> bookList = new List<Book>();
    }
}
