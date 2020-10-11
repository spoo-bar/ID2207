using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier
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

            //todo: temp solution
            var ev = new EventRequest("123abc", new Client("ddd", "", ""), "", DateTime.Now, DateTime.Now, 3, 23.4);
            
            Application.Run(new FinancialFeedbackForm(ev));
        }
    }
}
