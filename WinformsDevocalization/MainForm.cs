using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinformsDevocalization.Properties;

namespace WinformsDevocalization
{
    public partial class MainForm : Form
    {
        public MainForm() { InitializeComponent(); }

        private void ButtonDevocalize_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxInput.Text;
            new List<string>
            {
                "A",
                "a",
                "À",
                "à",
                "Á",
                "á",
                "Â",
                "â",
                "Ã",
                "ã",
                "Ä",
                "ä",
                "Å",
                "å",
                "Ǻ",
                "ǻ",
                "Ā",
                "ā",
                "Ă",
                "ă",
                "Ą",
                "ą",
                "Ǎ",
                "ǎ",
                "Ǟ",
                "ǟ",
                "Ǡ",
                "ǡ",
                "Ȁ",
                "ȁ",
                "Ȧ",
                "ȧ",
                "Ⱥ",
                "ⱥ",
                "Ḁ",
                "ḁ",
                "ẚ",
                "Ạ",
                "ạ",
                "Ả",
                "ả",
                "Ấ",
                "ấ",
                "Ầ",
                "ầ",
                "Ấ",
                "ấ",
                "Ẩ",
                "ẩ",
                "Ẫ",
                "ẫ",
                "Ậ",
                "ậ",
                "Ắ",
                "ắ",
                "Ằ",
                "ằ",
                "Ẳ",
                "ẳ",
                "Ẵ",
                "ẵ",
                "Ặ",
                "ặ",
                "Æ",
                "æ",
                "Ǽ",
                "ǽ",
                "Ǣ",
                "ǣ",
                "Ɑ",
                "ɑ",
                "Ɐ",
                "ɐ",
                "Ɒ",
                "ɒ",
                "A̱",
                "a̱",
                "A̮",
                "a̮",
                "Aͤ",
                "aͤ",
                "E",
                "e",
                "È",
                "è",
                "É",
                "é",
                "Ê",
                "ê",
                "Ë",
                "ë",
                "Ē",
                "ē",
                "Ĕ",
                "ĕ",
                "Ė",
                "ė",
                "Ė̄",
                "ė̄",
                "Ę",
                "ę",
                "Ě",
                "ě",
                "Ǝ",
                "ǝ",
                "Ɛ",
                "ɛ",
                "Ə",
                "ə",
                "Ȅ",
                "ȅ",
                "Ȇ",
                "ȇ",
                "Ȩ",
                "ȩ",
                "Ɇ",
                "ɇ",
                "Ḕ",
                "ḕ",
                "Ḗ",
                "ḗ",
                "Ḙ",
                "ḙ",
                "Ḛ",
                "ḛ",
                "Ḝ",
                "ḝ",
                "Ẹ",
                "ẹ",
                "Ẻ",
                "ẻ",
                "Ẽ",
                "ẽ",
                "Ế",
                "ế",
                "Ề",
                "ề",
                "Ể",
                "ể",
                "Ễ",
                "ễ",
                "Ệ",
                "ệ",
                "I",
                "i",
                "Ì",
                "ì",
                "Í",
                "í",
                "Î",
                "î",
                "Ï",
                "ï",
                "Ĩ",
                "ĩ",
                "Ī",
                "ī",
                "Ĭ",
                "ĭ",
                "Į",
                "į",
                "İ",
                "i",
                "I",
                "ı",
                "Ĳ",
                "ĳ",
                "Ɩ",
                "ɩ",
                "Ɨ",
                "ɨ",
                "Ǐ",
                "ǐ",
                "Ȉ",
                "ȉ",
                "Ȋ",
                "ȋ",
                "Ḭ",
                "ḭ",
                "Ḯ",
                "ḯ",
                "Ỉ",
                "ỉ",
                "Ị",
                "ị",
                "O",
                "o",
                "Ò",
                "ò",
                "Ó",
                "ó",
                "Ô",
                "ô",
                "Õ",
                "õ",
                "Ö",
                "ö",
                "Ø",
                "ø",
                "Oͤ",
                "oͤ",
                "Ǿ",
                "ǿ",
                "Ō",
                "ō",
                "Ŏ",
                "ŏ",
                "Ő",
                "ő",
                "Ɔ",
                "ɔ",
                "Ɵ",
                "ɵ",
                "Ơ",
                "ơ",
                "Ǒ",
                "ǒ",
                "Ǫ",
                "ǫ",
                "Ǭ",
                "ǭ",
                "Ȍ",
                "ȍ",
                "Ȏ",
                "ȏ",
                "Ȫ",
                "ȫ",
                "Ȭ",
                "ȭ",
                "Ȯ",
                "ȯ",
                "Ȱ",
                "ȱ",
                "Ṍ",
                "ṍ",
                "Ṏ",
                "ṏ",
                "Ṑ",
                "ṑ",
                "Ṓ",
                "ṓ",
                "O̧",
                "o̧",
                "Ọ",
                "ọ",
                "Ỏ",
                "ỏ",
                "Ố",
                "ố",
                "Ồ",
                "ồ",
                "Ổ",
                "ổ",
                "Ỗ",
                "ỗ",
                "Ộ",
                "ộ",
                "Ớ",
                "ớ",
                "Ờ",
                "ờ",
                "Ở",
                "ở",
                "Ỡ",
                "ỡ",
                "Ợ",
                "ợ",
                "O͘",
                "o͘",
                "Ꝋ",
                "ꝋ",
                "Ꝍ",
                "ꝍ",
                "Ꝏ",
                "ꝏ",
                "ⱺ",
                "Œ",
                "œ",
                "Ȯ",
                "ȯ",
                "U",
                "u",
                "Ú",
                "ú",
                "Û",
                "û",
                "Ù",
                "ù",
                "Ü",
                "ü",
                "Ŭ",
                "ŭ",
                "Ũ",
                "ũ",
                "Ū",
                "ū",
                "Ů",
                "ů",
                "Ű",
                "ű",
                "Ų",
                "ų",
                "Ư",
                "ư",
                "Ǔ",
                "ǔ",
                "Ǖ",
                "ǖ",
                "Ǘ",
                "ǘ",
                "Ǚ",
                "ǚ",
                "Ǜ",
                "ǜ",
                "Ȕ",
                "ȕ",
                "Ȗ",
                "ȗ",
                "Ʉ",
                "ʉ",
                "Ṳ",
                "ṳ",
                "Ṵ",
                "ṵ",
                "Ṷ",
                "ṷ",
                "Ṹ",
                "ṹ",
                "Ṻ",
                "ṻ",
                "Ụ",
                "ụ",
                "Ủ",
                "ủ",
                "Ứ",
                "ứ",
                "Ừ",
                "ừ",
                "Ử",
                "ử",
                "Ữ",
                "ữ",
                "Ự",
                "ự",
                "Uͤ",
                "uͤ",
                "U̇",
                "u̇"
            }.ForEach(action: m => textBoxOutput.Text = textBoxOutput.Text.Replace(oldValue: m, newValue: string.Empty));
            //"A","a","À","à","Á","á","Â","â","Ã","ã","Ä","ä","Å","å","Ǻ","ǻ","Ā","ā","Ă","ă","Ą","ą","Ǎ","ǎ","Ǟ","ǟ","Ǡ","ǡ","Ȁ","ȁ","Ȧ","ȧ","Ⱥ","ⱥ","Ḁ","ḁ","ẚ","Ạ","ạ","Ả","ả","Ấ","ấ","Ầ","ầ","Ấ","ấ","Ẩ","ẩ","Ẫ","ẫ","Ậ","ậ","Ắ","ắ","Ằ","ằ","Ẳ","ẳ","Ẵ","ẵ","Ặ","ặ","Æ","æ","Ǽ","ǽ","Ǣ","ǣ","Ɑ","ɑ","Ɐ","ɐ","Ɒ","ɒ","A̱","a̱","A̮","a̮","Aͤ","aͤ","E","e","È","è","É","é","Ê","ê","Ë","ë","Ē","ē","Ĕ","ĕ","Ė","ė","Ė̄","ė̄","Ę","ę","Ě","ě","Ǝ","ǝ","Ɛ","ɛ","Ə","ə","Ȅ","ȅ","Ȇ","ȇ","Ȩ","ȩ","Ɇ","ɇ","Ḕ","ḕ","Ḗ","ḗ","Ḙ","ḙ","Ḛ","ḛ","Ḝ","ḝ","Ẹ","ẹ","Ẻ","ẻ","Ẽ","ẽ","Ế","ế","Ề","ề","Ể","ể","Ễ","ễ","Ệ","ệ","I","i","Ì","ì","Í","í","Î","î","Ï","ï","Ĩ","ĩ","Ī","ī","Ĭ","ĭ","Į","į","İ","i","I","ı","Ĳ","ĳ","Ɩ","ɩ","Ɨ","ɨ","Ǐ","ǐ","Ȉ","ȉ","Ȋ","ȋ","Ḭ","ḭ","Ḯ","ḯ","Ỉ","ỉ","Ị","ị","O","o","Ò","ò","Ó","ó","Ô","ô","Õ","õ","Ö","ö","Ø","ø","Oͤ","oͤ","Ǿ","ǿ","Ō","ō","Ŏ","ŏ","Ő","ő","Ɔ","ɔ","Ɵ","ɵ","Ơ","ơ","Ǒ","ǒ","Ǫ","ǫ","Ǭ","ǭ","Ȍ","ȍ","Ȏ","ȏ","Ȫ","ȫ","Ȭ","ȭ","Ȯ","ȯ","Ȱ","ȱ","Ṍ","ṍ","Ṏ","ṏ","Ṑ","ṑ","Ṓ","ṓ","O̧","o̧","Ọ","ọ","Ỏ","ỏ","Ố","ố","Ồ","ồ","Ổ","ổ","Ỗ","ỗ","Ộ","ộ","Ớ","ớ","Ờ","ờ","Ở","ở","Ỡ","ỡ","Ợ","ợ","O͘","o͘","Ꝋ","ꝋ","Ꝍ","ꝍ","Ꝏ","ꝏ","ⱺ","Œ","œ","Ȯ","ȯ","U","u","Ú","ú","Û","û","Ù","ù","Ü","ü","Ŭ","ŭ","Ũ","ũ","Ū","ū","Ů","ů","Ű","ű","Ų","ų","Ư","ư","Ǔ","ǔ","Ǖ","ǖ","Ǘ","ǘ","Ǚ","ǚ","Ǜ","ǜ","Ȕ","ȕ","Ȗ","ȗ","Ʉ","ʉ","Ṳ","ṳ","Ṵ","ṵ","Ṷ","ṷ","Ṹ","ṹ","Ṻ","ṻ","Ụ","ụ","Ủ","ủ","Ứ","ứ","Ừ","ừ","Ử","ử","Ữ","ữ","Ự","ự","Uͤ","uͤ","U̇","u̇"
            if (menuItemRemoveMultipleSpaces.Checked)
            {
                RemoveMultipleSpaces();
            }
            if (menuItemShowStatisticAfterFinish.Checked)
            {
                OutputStatisticAsMessageBox();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonDevocalize.Enabled = false;
            menuItemShowStatistic.Enabled = false;
        }

        private void MenuItemExit_Click(object sender, EventArgs e) { Close(); }

        private void MenuItemShowStatistic_Click(object sender, EventArgs e) { OutputStatisticAsMessageBox(); }

        private void OutputStatisticAsMessageBox()
        {
            if (textBoxInput.TextLength < textBoxOutput.TextLength)
            {
                MessageBox.Show(
                    text: $"{Resources.inputTextMustNotBeSmallerThanOutputText}",
                    caption: Resources.warningTitle,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning,
                    defaultButton: MessageBoxDefaultButton.Button1);
                return;
            }
            if (textBoxOutput.TextLength < 1)
            {
                MessageBox.Show(
                    text: $"{Resources.outputTextMustNotBeEmpty}",
                    caption: Resources.warningTitle,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning,
                    defaultButton: MessageBoxDefaultButton.Button1);
                return;
            }
            uint numberReadedChars = 0;
            uint numberWrittenChars = 0;
            numberReadedChars += Convert.ToUInt32(value: textBoxInput.TextLength);
            numberWrittenChars += Convert.ToUInt32(value: textBoxOutput.TextLength);
            MessageBox.Show(
                text: $"{numberReadedChars}{Resources.space}{Resources.charsRead}{Resources.newLine}{numberWrittenChars}{Resources.space}{Resources.charsWritten}{Resources.newLine}{numberReadedChars - numberWrittenChars}{Resources.space}{Resources.charsRemoved}",
                caption: Resources.finishedTitle,
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information,
                defaultButton: MessageBoxDefaultButton.Button1);
        }

        private void RemoveMultipleSpaces()
        {
            while (textBoxOutput.Text.Contains(value: Resources.doubleSpace))
            {
                textBoxOutput.Text = textBoxOutput.Text
                    .Replace(oldValue: Resources.doubleSpace, newValue: Resources.space);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
