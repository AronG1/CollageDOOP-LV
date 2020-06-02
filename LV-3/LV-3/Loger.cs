using System;
using System.Collections.Generic;
using System.Text;

namespace LV_3
{
    class Loger
    {
        private static Loger instance;
        private string filePath;

        private Loger(string filePath)
        {
            this.filePath = filePath;
        }
        public static Loger GetInstance()
        {
            if (instance == null)
            {
                instance = new Loger("logger.txt");
            }
            return instance;
        }
        public void WriteLog(string data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, append: true))
            {
                writer.WriteLine("\n" + data);
            }
        }
    }
}
