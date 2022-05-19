using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public class TemplateTest
    {
        static void Main()
        {
            #region Generic Way of doing..
            //ExcelFile excel = new ExcelFile();
            //excel.ReadFile();
            //excel.ProcessFile();
            //excel.SaveFile();
            //TextFile text = new TextFile();
            //text.ReadFile();
            //text.ProcessFile();
            //text.SaveFile();
            #endregion

            #region Using Template Method Pattern
            ExcelFile excel = new ExcelFile();
            excel.ReadProcessSaveDB();
            TextFile text = new TextFile();
            text.ReadProcessSaveDB();
            #endregion

            Console.WriteLine("\n------------------------------------------\n");

            #region Using Template Method Pattern using Super class sub class implementation
            AbstractTemplate ex = new ExcelFile();
            ex.ReadProcessSaveDB();
            AbstractTemplate t = new TextFile();
            t.ReadProcessSaveDB();
            #endregion

            Console.Read();
        }
    }
}
