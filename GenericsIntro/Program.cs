using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();  //string yerine istediğini verebilirsin: int,class...
            isimler.Add("Engin");

            Console.WriteLine("Hello World!");
        }
    }
}
