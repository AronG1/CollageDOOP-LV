using System;
using System.Collections.Generic;
using System.Text;

namespace LV_3
{
    class Direktor
    {
        public void Construct(IBuilder builder, string author)
        {
            builder.SetAuthor(author).SetTitle("Header").SetText("Body").SetLevel(Category.ERROR).SetColor(ConsoleColor.Red).SetTime(DateTime.Now);
        }
    }
}
