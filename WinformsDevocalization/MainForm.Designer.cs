
namespace WinformsDevocalization
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.buttonDevocalize = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemShowStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemShowStatisticAfterFinish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRemoveMultipleSpaces = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput.MaxLength = 99999999;
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(250, 100);
            this.textBoxInput.TabIndex = 0;
            this.toolTip.SetToolTip(this.textBoxInput, "Input the text to devocalize");
            this.textBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.textBoxInput);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 27);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(256, 119);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // buttonDevocalize
            // 
            this.buttonDevocalize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDevocalize.Location = new System.Drawing.Point(15, 149);
            this.buttonDevocalize.Name = "buttonDevocalize";
            this.buttonDevocalize.Size = new System.Drawing.Size(250, 23);
            this.buttonDevocalize.TabIndex = 2;
            this.buttonDevocalize.Text = "Devocalize";
            this.toolTip.SetToolTip(this.buttonDevocalize, "Devocalize");
            this.buttonDevocalize.UseVisualStyleBackColor = true;
            this.buttonDevocalize.Click += new System.EventHandler(this.ButtonDevocalize_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.Controls.Add(this.textBoxOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 181);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(256, 119);
            this.groupBoxOutput.TabIndex = 3;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput.MaxLength = 99999999;
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(250, 100);
            this.textBoxOutput.TabIndex = 0;
            this.toolTip.SetToolTip(this.textBoxOutput, "Output as devocalized text");
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemTools,
            this.menuItemOptions});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(280, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuItemFile
            // 
            this.menuItemFile.AutoToolTip = true;
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemExit
            // 
            this.menuItemExit.AutoToolTip = true;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(180, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // menuItemTools
            // 
            this.menuItemTools.AutoToolTip = true;
            this.menuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemShowStatistic});
            this.menuItemTools.Name = "menuItemTools";
            this.menuItemTools.Size = new System.Drawing.Size(46, 20);
            this.menuItemTools.Text = "&Tools";
            // 
            // menuItemShowStatistic
            // 
            this.menuItemShowStatistic.AutoToolTip = true;
            this.menuItemShowStatistic.Name = "menuItemShowStatistic";
            this.menuItemShowStatistic.Size = new System.Drawing.Size(180, 22);
            this.menuItemShowStatistic.Text = "&Show statistic";
            this.menuItemShowStatistic.Click += new System.EventHandler(this.MenuItemShowStatistic_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.AutoToolTip = true;
            this.menuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemShowStatisticAfterFinish,
            this.menuItemRemoveMultipleSpaces});
            this.menuItemOptions.Name = "menuItemOptions";
            this.menuItemOptions.Size = new System.Drawing.Size(61, 20);
            this.menuItemOptions.Text = "&Options";
            // 
            // menuItemShowStatisticAfterFinish
            // 
            this.menuItemShowStatisticAfterFinish.AutoToolTip = true;
            this.menuItemShowStatisticAfterFinish.CheckOnClick = true;
            this.menuItemShowStatisticAfterFinish.Name = "menuItemShowStatisticAfterFinish";
            this.menuItemShowStatisticAfterFinish.Size = new System.Drawing.Size(205, 22);
            this.menuItemShowStatisticAfterFinish.Text = "S&how statistic after finish";
            // 
            // menuItemRemoveMultipleSpaces
            // 
            this.menuItemRemoveMultipleSpaces.AutoToolTip = true;
            this.menuItemRemoveMultipleSpaces.Checked = true;
            this.menuItemRemoveMultipleSpaces.CheckOnClick = true;
            this.menuItemRemoveMultipleSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemRemoveMultipleSpaces.Name = "menuItemRemoveMultipleSpaces";
            this.menuItemRemoveMultipleSpaces.Size = new System.Drawing.Size(205, 22);
            this.menuItemRemoveMultipleSpaces.Text = "&Remove multiple spaces";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 308);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.buttonDevocalize);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devocalization";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.GroupBox groupBoxInput;
		private System.Windows.Forms.Button buttonDevocalize;
		private System.Windows.Forms.GroupBox groupBoxOutput;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuItemFile;
		private System.Windows.Forms.ToolStripMenuItem menuItemExit;
		private System.Windows.Forms.ToolStripMenuItem menuItemOptions;
		private System.Windows.Forms.ToolStripMenuItem menuItemShowStatisticAfterFinish;
		private System.Windows.Forms.ToolStripMenuItem menuItemRemoveMultipleSpaces;
		private System.Windows.Forms.ToolStripMenuItem menuItemTools;
		private System.Windows.Forms.ToolStripMenuItem menuItemShowStatistic;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

