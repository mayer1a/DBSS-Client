#region  Namespaces and lib

using System;
using System.Windows.Forms;

#endregion

namespace ServiceStation
{
	static class DBSS
	{
		public static short staffID;
		public static bool reauthorize;

		/// <summary>
		/// Main application entry point
		/// </summary>
		[STAThread]

		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			do
			{
				reauthorize = false;
				Application.Run(new AuthorizationForm());

				if (staffID.Equals(20))
					Application.Run(new MainForm());
				else if(!staffID.Equals(0))
					//Запуск формы д/мастеров
					Application.Run(new FinderForm("Cars"));
			} while (reauthorize);
		}
	}
}