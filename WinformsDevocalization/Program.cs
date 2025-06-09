using System;
using System.Windows.Forms;

// Specifies that the assembly is compliant with the Common Language Specification (CLS).
// This ensures that the public APIs of the assembly can be used by all .NET languages that support CLS.
[assembly: CLSCompliant(isCompliant: true)]

namespace WinformsDevocalization
{
	/// <summary>
	/// Provides the main entry point for the WinformsDevocalization application.
	/// This class is static and cannot be instantiated.
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		// The STAThread attribute is required for Windows Forms applications to use single-threaded apartment model.
		[STAThread]

		private static void Main()
		{
			// Enables Windows visual styles for the application, making controls use the current Windows theme.
			Application.EnableVisualStyles();
			// Sets the default text rendering to GDI+ for better compatibility with custom controls.
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			// Starts the application and opens the main form (MainForm).
			Application.Run(mainForm: new MainForm());
		}
	}
}
