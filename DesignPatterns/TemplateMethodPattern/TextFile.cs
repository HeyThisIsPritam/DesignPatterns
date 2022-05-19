using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public class TextFile : AbstractTemplate
    {
        public override void ReadFile()  //to implement Abstract we need override keyword in abstract method
        {
            Console.WriteLine("Read the Text File.");
        }
        public override void ProcessFile()  //to implement Abstract we need override keyword in abstract method
        {
            Console.WriteLine("Process the Text FIle.");
        }

        //public void SaveFile()             // Commenting as this method is common type.  
        //{
        //    Console.WriteLine("Save the Processed File to DB.");
        //}
    }
}
