using SGB;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Presentacion
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using var context = new BibliotecaBDContext();
            context.Database.EnsureCreated();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
    }
}