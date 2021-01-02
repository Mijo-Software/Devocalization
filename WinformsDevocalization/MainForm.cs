using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinformsDevocalization.Properties;

namespace WinformsDevocalization
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void RemoveMultipleSpaces()
		{
			while (textBoxOutput.Text.Contains(value: Resources.doubleSpace))
			{
				textBoxOutput.Text = textBoxOutput.Text.Replace(oldValue: Resources.doubleSpace, newValue: Resources.space);
			}
		}

		private void OutputStatisticAsMessageBox()
		{
			if (textBoxInput.TextLength < textBoxOutput.TextLength)
			{
				MessageBox.Show(text: $"{Resources.inputTextMustNotBeSmallerThanOutputText}", caption: Resources.warningTitle, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning, defaultButton: MessageBoxDefaultButton.Button1);
			}
			else if (textBoxOutput.TextLength < 1)
			{
				MessageBox.Show(text: $"{Resources.outputTextMustNotBeEmpty}", caption: Resources.warningTitle, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning, defaultButton: MessageBoxDefaultButton.Button1);
			}
			else
			{
				uint numberReadedChars = 0;
				uint numberWrittenChars = 0;
				numberReadedChars += Convert.ToUInt32(value: textBoxInput.TextLength);
				numberWrittenChars += Convert.ToUInt32(value: textBoxOutput.TextLength);
				MessageBox.Show(text: $"{numberReadedChars}{Resources.space}{Resources.charsRead}{Resources.newLine}{numberWrittenChars}{Resources.space}{Resources.charsWritten}{Resources.newLine}{numberReadedChars - numberWrittenChars}{Resources.space}{Resources.charsRemoved}", caption: Resources.finishedTitle, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information, defaultButton: MessageBoxDefaultButton.Button1);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			buttonDevocalize.Enabled = false;
			menuItemShowStatistic.Enabled = false;
		}

		private void ButtonDevocalize_Click(object sender, EventArgs e)
		{
			textBoxOutput.Text = textBoxInput.Text;
			new List<string> { "A", "a", "E", "e", "I", "i", "O", "o", "U", "u" }.ForEach(m => textBoxOutput.Text = textBoxOutput.Text.Replace(oldValue: m, newValue: string.Empty));
			if (menuItemRemoveMultipleSpaces.Checked)
			{
				RemoveMultipleSpaces();
			}
			if (menuItemShowStatisticAfterFinish.Checked)
			{
				OutputStatisticAsMessageBox();
			}
		}

		private void TextBoxInput_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(value: textBoxInput.Text))
			{
				buttonDevocalize.Enabled = false;
				menuItemShowStatistic.Enabled = false;
			}
			else
			{
				if (!buttonDevocalize.Enabled)
				{
					buttonDevocalize.Enabled = true;
					menuItemShowStatistic.Enabled = true;
				}
			}
		}

		private void MenuItemShowStatistic_Click(object sender, EventArgs e)
		{
			OutputStatisticAsMessageBox();
		}

		private void MenuItemExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
