using SS.Services.Interfaces;
using SS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SS.Repositories;
using SS.Repositories.Interfaces;

namespace SS.ViewLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configuración manual de dependencias
            IUsersRepository usersRepository = new UsersRepository();
            IUsersService usersService = new UsersService(usersRepository);

            Application.Run(new Login(usersService));
        }
    }
}
