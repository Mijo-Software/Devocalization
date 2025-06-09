using System;
using System.IO;
using System.Reflection;
using NLog;

namespace DisksizeWatcher
{
	/// <summary>
	/// Provides access to various assembly information such as title, version, description, product, copyright, and company.
	/// All properties are static and retrieve their values from the executing assembly's attributes.
	/// </summary>
	public static class AssemblyInfo
	{
		/// <summary>
		/// Logger instance for error logging within the AssemblyInfo class.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		#region Assembly attribute accessors

		/// <summary>
		/// Gets the title of the assembly. If the title attribute is not set, returns the file name without extension.
		/// </summary>
		public static string AssemblyTitle
		{
			get
			{
				try
				{
					object[] attributes = Assembly.GetExecutingAssembly()
						.GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
					return attributes.Length > 0 && attributes[0] is AssemblyTitleAttribute titleAttribute
						? !string.IsNullOrEmpty(value: titleAttribute.Title) ? titleAttribute.Title : Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().Location)
						: Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().Location);
				}
				catch (Exception ex)
				{
					Logger.Error(exception: ex, message: "An error occurred while retrieving the assembly title.");
					return string.Empty;
				}
			}
		}

		/// <summary>
		/// Gets the version of the assembly as a string.
		/// </summary>
		public static string AssemblyVersion
		{
			get
			{
				try
				{
					return Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? string.Empty;
				}
				catch (Exception ex)
				{
					Logger.Error(exception: ex, message: "An error occurred while retrieving the assembly version.");
					return string.Empty;
				}
			}
		}

		/// <summary>
		/// Gets the description of the assembly. Returns an empty string if not set.
		/// </summary>
		public static string AssemblyDescription
		{
			get
			{
				try
				{
					object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
					return attributes.Length == 0 ? string.Empty : ((AssemblyDescriptionAttribute)attributes[0]).Description;
				}
				catch (Exception ex)
				{
					Logger.Error(exception: ex, message: "An error occurred while retrieving the assembly description.");
					return string.Empty;
				}
			}
		}

		/// <summary>
		/// Gets the product name of the assembly. Returns an empty string if not set.
		/// </summary>
		public static string AssemblyProduct
		{
			get
			{
				try
				{
					object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
					return attributes.Length == 0 ? string.Empty : ((AssemblyProductAttribute)attributes[0]).Product;
				}
				catch (Exception ex)
				{
					Logger.Error(exception: ex, message: "An error occurred while retrieving the assembly product.");
					return string.Empty;
				}
			}
		}

		/// <summary>
		/// Gets the copyright information of the assembly. Returns an empty string if not set.
		/// </summary>
		public static string AssemblyCopyright
		{
			get
			{
				try
				{
					object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
					return attributes.Length == 0 ? string.Empty : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
				}
				catch (Exception ex)
				{
					Logger.Error(exception: ex, message: "An error occurred while retrieving the assembly copyright.");
					return string.Empty;
				}
			}
		}

		/// <summary>
		/// Gets the company name of the assembly. Returns an empty string if not set.
		/// </summary>
		public static string AssemblyCompany
		{
			get
			{
				try
				{
					object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
					return attributes.Length == 0 ? string.Empty : ((AssemblyCompanyAttribute)attributes[0]).Company;
				}
				catch (Exception ex)
				{
					Logger.Error(exception: ex, message: "An error occurred while retrieving the assembly company.");
					return string.Empty;
				}
			}
		}

		#endregion
	}
}