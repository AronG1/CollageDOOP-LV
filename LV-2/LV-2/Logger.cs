using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_2
{

    interface ILogger
    {
        void Log(string message);
    }

    class Logger
    {
        private string type;
        protected string filePath;

        public Logger()
        {
            this.type = "File";
            this.filePath = null;
        }

        public Logger(string type, string filePath)
        {
            this.type = type;
            this.filePath = filePath;
        }

        public void Log(string message)
        {
            if (type.Equals("Console"))
                Console.WriteLine(message);
            else if (type.Equals("File"))
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
                {
                    writer.WriteLine(message);
                }
            else
                throw new ArgumentException("Unknown type"); // ha, kao da bi to napravio u produkciji ikad...
        }

    }
}
