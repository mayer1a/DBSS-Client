#region  Namespaces and lib

using System;
using System.Windows.Forms;

#endregion

namespace ServiceStation
{
    static class DBSS
    {
        #region Variables

        public static short staffID;
        private const short adminID = 20;
        public static bool reauthorize;

        #endregion

        /// <summary>
        /// Main application entry point
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            #region Code for debug

            // Not need code.
            // -------------------------------------------------------------------
            //Application.Run(new FinderForm("Cars"));
            //Application.Run(new PasswordForm());
            //Application.Run(new AskYearForm());
            //Application.Run(new MainForm());
            //Application.Exit();
            //return;
            // -------------------------------------------------------------------

            #endregion

            do
            {
                reauthorize = false;
                Application.Run(new AuthorizationForm());

                if (staffID.Equals(adminID))
                    Application.Run(new MainForm());

                //Запуск формы д/мастеров
                else
                    Application.Run(new EmployeeForm());

            } while (reauthorize);
        }
    }
}