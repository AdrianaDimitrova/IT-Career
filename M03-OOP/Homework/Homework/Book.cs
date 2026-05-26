using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


public class Book
{
    private string title;
    private string author;
    private int pages;

     public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int Pages
    {
        get { return pages; }
        set 
        {
            if (value > 0)
            {
                pages = value;
            }

            else
            {
                throw new ArgumentException("Страниците трябва да бъдат положително число!");
            }
        }
    }

    public void Print()
    {
        
        Console.WriteLine($"{Title} - {Author} ({Pages} стр.)");
    }
}


