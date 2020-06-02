using System;

namespace LV7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                Pali.Unos();
                if (Pali.word?.ToLower() == "letmeout") break;
            }
        }


    }
}
