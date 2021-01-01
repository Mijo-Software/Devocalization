using System;
using System.Windows.Forms;

[assembly: CLSCompliant(true)]
namespace WinformsDevocalization
{
	internal static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(mainForm: new MainForm());
		}
	}
}
