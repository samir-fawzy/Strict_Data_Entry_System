using DAL.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using Serilog;
namespace PL
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var context = DbConfig.CreateContext())
            {
                DbIntitializer.EnsureMigrationSaved(context);

            }

            Application.Run(new InittialForm());
        }
    }
}