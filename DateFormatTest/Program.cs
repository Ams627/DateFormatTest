using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFormatTest
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                DateTime date = DateTime.Now;
                var format = "yyyy-MM-dd";
                var s = $"{{date:{format}}}";
                Console.WriteLine(s);
                var formatString = $"the date is {{0:{format}}}";
                var str = string.Format(formatString, date);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
