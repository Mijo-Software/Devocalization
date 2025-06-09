
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinformsDevocalization
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
			this.textBoxInput = new TextBox();
			this.groupBoxInput = new GroupBox();
			this.buttonDevocalize = new Button();
			this.groupBoxOutput = new GroupBox();
			this.textBoxOutput = new TextBox();
			this.menuStrip = new MenuStrip();
			this.menuItemFile = new ToolStripMenuItem();
			this.menuItemExit = new ToolStripMenuItem();
			this.menuItemTools = new ToolStripMenuItem();
			this.menuItemShowStatistic = new ToolStripMenuItem();
			this.menuItemOptions = new ToolStripMenuItem();
			this.menuItemShowStatisticAfterFinish = new ToolStripMenuItem();
			this.menuItemRemoveMultipleSpaces = new ToolStripMenuItem();
			this.toolTip = new ToolTip(this.components);
			this.statusStrip = new StatusStrip();
			this.toolStripStatusLabel = new ToolStripStatusLabel();
			this.toolStripMenuItemAbout = new ToolStripMenuItem();
			this.groupBoxInput.SuspendLayout();
			this.groupBoxOutput.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxInput
			// 
			this.textBoxInput.Dock = DockStyle.Fill;
			this.textBoxInput.Location = new Point(3, 16);
			this.textBoxInput.MaxLength = 99999999;
			this.textBoxInput.Multiline = true;
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.ScrollBars = ScrollBars.Vertical;
			this.textBoxInput.Size = new Size(250, 100);
			this.textBoxInput.TabIndex = 0;
			this.toolTip.SetToolTip(this.textBoxInput, "Input the text to devocalize");
			this.textBoxInput.TextChanged += new EventHandler(this.TextBoxInput_TextChanged);
			// 
			// groupBoxInput
			// 
			this.groupBoxInput.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
			                                             | AnchorStyles.Right)));
			this.groupBoxInput.Controls.Add(this.textBoxInput);
			this.groupBoxInput.Location = new Point(12, 27);
			this.groupBoxInput.Name = "groupBoxInput";
			this.groupBoxInput.Size = new Size(256, 119);
			this.groupBoxInput.TabIndex = 1;
			this.groupBoxInput.TabStop = false;
			this.groupBoxInput.Text = "Input";
			// 
			// buttonDevocalize
			// 
			this.buttonDevocalize.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
			                                                | AnchorStyles.Right)));
			this.buttonDevocalize.Location = new Point(15, 149);
			this.buttonDevocalize.Name = "buttonDevocalize";
			this.buttonDevocalize.Size = new Size(250, 23);
			this.buttonDevocalize.TabIndex = 2;
			this.buttonDevocalize.Text = "Devocalize";
			this.toolTip.SetToolTip(this.buttonDevocalize, "Devocalize");
			this.buttonDevocalize.UseVisualStyleBackColor = true;
			this.buttonDevocalize.Click += new EventHandler(this.ButtonDevocalize_Click);
			// 
			// groupBoxOutput
			// 
			this.groupBoxOutput.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
			                                              | AnchorStyles.Right)));
			this.groupBoxOutput.Controls.Add(this.textBoxOutput);
			this.groupBoxOutput.Location = new Point(12, 181);
			this.groupBoxOutput.Name = "groupBoxOutput";
			this.groupBoxOutput.Size = new Size(256, 119);
			this.groupBoxOutput.TabIndex = 3;
			this.groupBoxOutput.TabStop = false;
			this.groupBoxOutput.Text = "Output";
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Dock = DockStyle.Fill;
			this.textBoxOutput.Location = new Point(3, 16);
			this.textBoxOutput.MaxLength = 99999999;
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.ScrollBars = ScrollBars.Vertical;
			this.textBoxOutput.Size = new Size(250, 100);
			this.textBoxOutput.TabIndex = 0;
			this.toolTip.SetToolTip(this.textBoxOutput, "Output as devocalized text");
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new ToolStripItem[] {
            this.menuItemFile,
            this.menuItemTools,
            this.menuItemOptions});
			this.menuStrip.Location = new Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new Size(280, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// menuItemFile
			// 
			this.menuItemFile.AutoToolTip = true;
			this.menuItemFile.DropDownItems.AddRange(new ToolStripItem[] {
            this.toolStripMenuItemAbout,
            this.menuItemExit});
			this.menuItemFile.Name = "menuItemFile";
			this.menuItemFile.Size = new Size(37, 20);
			this.menuItemFile.Text = "&File";
			// 
			// menuItemExit
			// 
			this.menuItemExit.AutoToolTip = true;
			this.menuItemExit.Name = "menuItemExit";
			this.menuItemExit.Size = new Size(180, 22);
			this.menuItemExit.Text = "E&xit";
			this.menuItemExit.Click += new EventHandler(this.MenuItemExit_Click);
			// 
			// menuItemTools
			// 
			this.menuItemTools.AutoToolTip = true;
			this.menuItemTools.DropDownItems.AddRange(new ToolStripItem[] {
            this.menuItemShowStatistic});
			this.menuItemTools.Name = "menuItemTools";
			this.menuItemTools.Size = new Size(46, 20);
			this.menuItemTools.Text = "&Tools";
			// 
			// menuItemShowStatistic
			// 
			this.menuItemShowStatistic.AutoToolTip = true;
			this.menuItemShowStatistic.Name = "menuItemShowStatistic";
			this.menuItemShowStatistic.Size = new Size(180, 22);
			this.menuItemShowStatistic.Text = "&Show statistic";
			this.menuItemShowStatistic.Click += new EventHandler(this.MenuItemShowStatistic_Click);
			// 
			// menuItemOptions
			// 
			this.menuItemOptions.AutoToolTip = true;
			this.menuItemOptions.DropDownItems.AddRange(new ToolStripItem[] {
            this.menuItemShowStatisticAfterFinish,
            this.menuItemRemoveMultipleSpaces});
			this.menuItemOptions.Name = "menuItemOptions";
			this.menuItemOptions.Size = new Size(61, 20);
			this.menuItemOptions.Text = "&Options";
			// 
			// menuItemShowStatisticAfterFinish
			// 
			this.menuItemShowStatisticAfterFinish.AutoToolTip = true;
			this.menuItemShowStatisticAfterFinish.CheckOnClick = true;
			this.menuItemShowStatisticAfterFinish.Name = "menuItemShowStatisticAfterFinish";
			this.menuItemShowStatisticAfterFinish.Size = new Size(205, 22);
			this.menuItemShowStatisticAfterFinish.Text = "S&how statistic after finish";
			// 
			// menuItemRemoveMultipleSpaces
			// 
			this.menuItemRemoveMultipleSpaces.AutoToolTip = true;
			this.menuItemRemoveMultipleSpaces.Checked = true;
			this.menuItemRemoveMultipleSpaces.CheckOnClick = true;
			this.menuItemRemoveMultipleSpaces.CheckState = CheckState.Checked;
			this.menuItemRemoveMultipleSpaces.Name = "menuItemRemoveMultipleSpaces";
			this.menuItemRemoveMultipleSpaces.Size = new Size(205, 22);
			this.menuItemRemoveMultipleSpaces.Text = "&Remove multiple spaces";
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new Point(0, 317);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new Size(280, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 4;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new Size(70, 17);
			this.toolStripStatusLabel.Text = "information";
			// 
			// toolStripMenuItemAbout
			// 
			this.toolStripMenuItemAbout.AutoToolTip = true;
			this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
			this.toolStripMenuItemAbout.Size = new Size(180, 22);
			this.toolStripMenuItemAbout.Text = "About...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(280, 339);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.groupBoxOutput);
			this.Controls.Add(this.buttonDevocalize);
			this.Controls.Add(this.groupBoxInput);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Devocalization";
			this.Load += new EventHandler(this.MainForm_Load);
			this.groupBoxInput.ResumeLayout(false);
			this.groupBoxInput.PerformLayout();
			this.groupBoxOutput.ResumeLayout(false);
			this.groupBoxOutput.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBoxInput;
		private GroupBox groupBoxInput;
		private Button buttonDevocalize;
		private GroupBox groupBoxOutput;
		private TextBox textBoxOutput;
		private MenuStrip menuStrip;
		private ToolStripMenuItem menuItemFile;
		private ToolStripMenuItem menuItemExit;
		private ToolStripMenuItem menuItemOptions;
		private ToolStripMenuItem menuItemShowStatisticAfterFinish;
		private ToolStripMenuItem menuItemRemoveMultipleSpaces;
		private ToolStripMenuItem menuItemTools;
		private ToolStripMenuItem menuItemShowStatistic;
        private ToolTip toolTip;
		private StatusStrip statusStrip;
		private ToolStripMenuItem toolStripMenuItemAbout;
		private ToolStripStatusLabel toolStripStatusLabel;
	}
}

