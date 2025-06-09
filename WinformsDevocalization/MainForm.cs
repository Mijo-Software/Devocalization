using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinformsDevocalization.Properties;

namespace WinformsDevocalization
{
	/// <summary>
	/// The main form of the WinformsDevocalization application.
	/// Provides UI and logic for removing vowels and related characters from input text.
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Set of characters (vowels and related Unicode characters) to be removed from the input text.
		/// </summary>
		private static readonly HashSet<char> CharactersToRemove = new(
			collection: "AaÀàÁáÂâÃãÄäÅåǺǻĀāĂăĄąǍǎǞǟǠǡȀȁȦȧȺⱥḀḁẚẠạẢảẤấẦầẨẩẪẫẬậẮắẰằẲẳẴẵẶặÆæǼǽǢǣⱭɑⱯɐⱰɒA̱a̱A̮a̮AͤaͤEeÈèÉéÊêËëĒēĔĕĖėĖ̄ė̄ĘęĚěƎǝƐɛƏəȄȅȆȇȨȩɆɇḔḕḖḗḘḙḚḛḜḝẸẹẺẻẼẽẾếỀềỂểỄễỆệIiÌìÍíÎîÏïĨĩĪīĬĭĮįİiIıĲĳƖɩƗɨǏǐȈȉȊȋḬḭḮḯỈỉỊịOoÒòÓóÔôÕõÖöØøOͤoͤǾǿŌōŎŏŐőƆɔƟɵƠơǑǒǪǫǬǭȌȍȎȏȪȫȬȭȮȯȰȱṌṍṎṏṐṑṒṓO̧o̧ỌọỎỏỐốỒồỔổỖỗỘộỚớỜờỞởỠỡỢợO͘o͘ꝊꝋꝌꝍꝎꝏⱺŒœȮȯUuÚúÛûÙùÜüŬŭŨũŪūŮůŰűŲųƯưǓǔǕǖǗǘǙǚǛǜȔȕȖȗɄʉṲṳṴṵṶṷṸṹṺṻỤụỦủỨứỪừỬửỮữỰựUͤuͤU̇u̇"
		);

		/// <summary>
		/// Initializes a new instance of the <see cref="MainForm"/> class.
		/// </summary>
		public MainForm() { InitializeComponent(); }

		/// <summary>
		/// Handles the click event of the Devocalize button.
		/// Removes all specified characters from the input text and updates the output text box.
		/// Optionally removes multiple spaces and shows statistics if enabled.
		/// </summary>
		private void ButtonDevocalize_Click(object sender, EventArgs e)
		{
			string inputText = textBoxInput.Text;
			StringBuilder outputText = new();

			// Remove all characters that are in CharactersToRemove
			foreach (char ch in inputText.Where(ch => !CharactersToRemove.Contains(item: ch)))
			{
				_ = outputText.Append(value: ch);
			}

			textBoxOutput.Text = outputText.ToString();

			// Optionally remove multiple spaces
			if (menuItemRemoveMultipleSpaces.Checked)
			{
				RemoveMultipleSpaces();
			}
			// Optionally show statistics after processing
			if (menuItemShowStatisticAfterFinish.Checked)
			{
				OutputStatisticAsMessageBox();
			}
		}

		/// <summary>
		/// Handles the form load event.
		/// Disables the Devocalize button and statistic menu item initially.
		/// </summary>
		private void MainForm_Load(object sender, EventArgs e)
		{
			buttonDevocalize.Enabled = false;
			menuItemShowStatistic.Enabled = false;
		}

		/// <summary>
		/// Handles the click event of the Exit menu item.
		/// Closes the application.
		/// </summary>
		private void MenuItemExit_Click(object sender, EventArgs e) { Close(); }

		/// <summary>
		/// Handles the click event of the Show Statistic menu item.
		/// Displays the statistics in a message box.
		/// </summary>
		private void MenuItemShowStatistic_Click(object sender, EventArgs e) { OutputStatisticAsMessageBox(); }

		/// <summary>
		/// Shows a message box with statistics about the number of characters read, written, and removed.
		/// </summary>
		private void OutputStatisticAsMessageBox()
		{
			// Validate input and output text lengths
			if (textBoxInput.TextLength < textBoxOutput.TextLength)
			{
				_ = MessageBox.Show(
					text: $@"{Resources.inputTextMustNotBeSmallerThanOutputText}",
					caption: Resources.warningTitle,
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Warning,
					defaultButton: MessageBoxDefaultButton.Button1);
				return;
			}
			if (textBoxOutput.TextLength < 1)
			{
				_ = MessageBox.Show(
					text: $@"{Resources.outputTextMustNotBeEmpty}",
					caption: Resources.warningTitle,
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Warning,
					defaultButton: MessageBoxDefaultButton.Button1);
				return;
			}
			uint numberReadedChars = Convert.ToUInt32(value: textBoxInput.TextLength);
			uint numberWrittenChars = Convert.ToUInt32(value: textBoxOutput.TextLength);
			string message = new StringBuilder()
				.Append(value: numberReadedChars).Append(value: Resources.space).Append(value: Resources.charsRead).Append(value: Resources.newLine)
				.Append(value: numberWrittenChars).Append(value: Resources.space).Append(value: Resources.charsWritten).Append(value: Resources.newLine)
				.Append(value: numberReadedChars - numberWrittenChars).Append(value: Resources.space).Append(value: Resources.charsRemoved)
				.ToString();

			_ = MessageBox.Show(
				text: message,
				caption: Resources.finishedTitle,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information,
				defaultButton: MessageBoxDefaultButton.Button1);
		}

		/// <summary>
		/// Replaces multiple consecutive whitespace characters in the output text with a single space.
		/// </summary>
		private void RemoveMultipleSpaces()
		{
			textBoxOutput.Text = Regex.Replace(input: textBoxOutput.Text, pattern: @"\s{2,}", replacement: " ");
		}

		/// <summary>
		/// Handles the TextChanged event of the input text box.
		/// Enables or disables the Devocalize button and statistic menu item based on input presence.
		/// </summary>
		private void TextBoxInput_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(value: textBoxInput.Text))
			{
				buttonDevocalize.Enabled = false;
				menuItemShowStatistic.Enabled = false;
				return;
			}
			if (!buttonDevocalize.Enabled)
			{
				buttonDevocalize.Enabled = true;
				menuItemShowStatistic.Enabled = true;
			}
		}
	}
}