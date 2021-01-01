using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinformsDevocalization
{
	public partial class MainForm : Form
	{
		public MainForm() => InitializeComponent();

		private void ButtonDevocalize_Click(object sender, EventArgs e)
		{
			textBoxOutput.Text = textBoxInput.Text;
			new List<string> { "A", "a", "E", "e", "I", "i", "O", "o", "U", "u" }.ForEach(m => textBoxOutput.Text = textBoxOutput.Text.Replace(oldValue: m, newValue: string.Empty));
		}

		private void TextBoxInput_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(value: textBoxInput.Text))
			{
				buttonDevocalize.Enabled = false;
			}
			else
			{
				if (!buttonDevocalize.Enabled)
				{
					buttonDevocalize.Enabled = true;
				}
			}
		}
	}
}
