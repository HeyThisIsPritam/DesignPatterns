using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public abstract class AbstractTemplate
    {
        public void ReadProcessSaveDB()
        {
            ReadFile();
            ProcessFile();
            SaveFile();
        }

        public abstract void ReadFile();
        public abstract void ProcessFile();

        public void SaveFile()                
        {
            Console.WriteLine("Save the Processed File to DB.");
        }
    }
}
