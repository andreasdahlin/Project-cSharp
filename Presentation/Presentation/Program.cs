using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainInterfaceForm());

            try
            {
                var xmlDoc = new XmlDocument();
                const string file = @"http://podcasts.joerogan.net/feed";
                xmlDoc.Load(file);
                xmlDoc.Save(Console.Out);
                Console.Read();

            }
            catch (Exception e)
            {
                Console.WriteLine(@"The file could not be read.");
                Console.WriteLine(e.Message);
                
            }
            Console.Read();
        }
    }
}
