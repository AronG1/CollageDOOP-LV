using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LV_2
{
    class FileLogger : Logger ,ILogger
    {
        void ILogger.Log(string message)
        {
            if (filePath != null)
                using (StreamWriter writer = new StreamWriter(this.filePath))
                {
                    writer.WriteLine(message);
                }
            else
                throw new Exception("File path is null!");
        }
    }
}
