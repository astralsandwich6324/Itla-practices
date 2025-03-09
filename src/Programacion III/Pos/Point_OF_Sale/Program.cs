using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace POS
{
    static class Program
    {
        internal static IConfiguration Config { get; private set; } // Variable global de configuración

        [STAThread]
        static void Main()
        {
            // Cargar configuración desde appsettings.json
            Config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
