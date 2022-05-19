using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public class ExcelFile : AbstractTemplate
    {
        public override void ReadFile()  //to implement Abstract we need override keyword in abstract method
        {
            Console.WriteLine("Read the Excel File.");
        }
        public override void ProcessFile()  //to implement Abstract we need override keyword in abstract method
        {
            Console.WriteLine("Process the Excel FIle.");
        }
        //public void SaveFile()                // Commenting as this method is common type.
        //{
        //    Console.WriteLine("Save the Processed File to DB.");
        //}
    }
}
