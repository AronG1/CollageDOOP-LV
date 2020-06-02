using System;
using System.Collections.Generic;
using System.Text;

namespace LV_3
{
    class NotificationBuilder : IBuilder
    {
        public String Author;
        public String Title;
        public String Text;
        public DateTime Timestamp;
        public Category Level;
        public ConsoleColor Color;

        public NotificationBuilder() { }

        public ConsoleNotification Build()
        {
            return new ConsoleNotification(Author, Title, Text, Timestamp, Level, Color);
        }
        public IBuilder SetAuthor(String author)
        {
            this.Author = author; return this;
        }
        public IBuilder SetTitle(String title)
        {
            this.Title = title; return this;
        }
        public IBuilder SetTime(DateTime time)
        {
            this.Timestamp = time; return this;
        }
        public IBuilder SetLevel(Category level)
        {
            this.Level = level; return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.Color = color; return this;
        }
        public IBuilder SetText(String text)
        {
            this.Text = text; return this;
        }
    }
}
