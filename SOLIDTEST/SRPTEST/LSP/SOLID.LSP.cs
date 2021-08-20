using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace DotNetDesignPatternDemos.SOLID.LiskovSubstitutionPrinciple
{
  // using a classic example
  public class Rectangle
  {
    // public int Width { get; set; }
    // public int Height { get; set; }

    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public Rectangle()
    {
      
    }

    public Rectangle(int width, int height)
    {
      Width = width;
      Height = height;
    }

    public override string ToString()
    {
      return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
  }

  public class Square : Rectangle
  {
    // public new int Width
    // {
    //  set { base.Width = base.Height = value; }
    //  get { return Width; }
    // }
    //
    // public new int Height
    // { 
    //  set { base.Width = base.Height = value; }
    //  get { return Height; }
    // }
    public override int Width // nasty side effects
    {
      set { base.Width = base.Height = value; }
    }

    public override int Height
    { 
      set { base.Width = base.Height = value; }
    }

    public Square()
    {
        if(Width != Height){
          throw new System.Exception();
        }
    }
  }

  public class Demo
  {
    static public int Area(Rectangle r) => r.Width * r.Height;

    // public static void Main(string[] args)
    // {
    //   Rectangle rc = new Rectangle(2,3);
    //   WriteLine($"{rc} has area {Area(rc)}");

    //   // should be able to substitute a base type for a subtype
    //   /*Square*/ Rectangle sq = new Square();
    //   sq.Width = 4;
    //   sq.Height = 4;
    //   WriteLine($"{sq} has area {Area(sq)}");

    //   KeyValuePair<string, int> aa = new KeyValuePair<string, int>("test", 11);

    //   Hashtable openWith = new Hashtable();

    //   // Add some elements to the hash table. There are no
    //   // duplicate keys, but some of the values are duplicates.
    //   openWith.Add("txt", "notepad.exe");
    //   openWith.Add("bmp", "paint.exe");
    //   openWith.Add("dib", "paint.exe");
    //   openWith.Add("rtf", "wordpad.exe");

    //   // When you use foreach to enumerate hash table elements,
    //   // the elements are retrieved as DictionaryEntry objects.
    //   Console.WriteLine();
    //   foreach (DictionaryEntry de in openWith)
    //   {
    //       Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
    //   }

    //   DictionaryEntry ddd = new DictionaryEntry(aa, 11);
    // }
  }
}
