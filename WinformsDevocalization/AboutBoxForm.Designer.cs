using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Automation;

namespace WinformsDevocalization
{
	sealed partial class AboutBoxForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AboutBoxForm));
            this.tableLayoutPanel = new TableLayoutPanel();
            this.logoPictureBox = new PictureBox();
            this.labelProductName = new Label();
            this.labelVersion = new Label();
            this.labelCopyright = new Label();
            this.labelCompanyName = new Label();
            this.textBoxDescription = new TextBox();
            this.okButton = new Button();
            this.toolTip = new ToolTip(this.components);
            this.statusStrip = new StatusStrip();
            this.labelInformation = new ToolStripStatusLabel();
            this.toolStripContainer = new ToolStripContainer();
            this.tableLayoutPanel.SuspendLayout();
            ((ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AccessibleDescription = "Just a pane";
            this.tableLayoutPanel.AccessibleName = "pane";
            this.tableLayoutPanel.AccessibleRole = AccessibleRole.Pane;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.75F));
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.25F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = DockStyle.Fill;
            this.tableLayoutPanel.Location = new Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 36.94268F));
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.84076F));
            this.tableLayoutPanel.Size = new Size(240, 116);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.AccessibleDescription = "This is the program icon.";
            this.logoPictureBox.AccessibleName = "program icon";
            this.logoPictureBox.AccessibleRole = AccessibleRole.Graphic;
            this.logoPictureBox.Dock = DockStyle.Fill;
            this.logoPictureBox.Location = new Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new Size(39, 110);
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.logoPictureBox, "program icon");
            this.logoPictureBox.MouseEnter += new EventHandler(this.SetStatusBar_Enter);
            this.logoPictureBox.MouseLeave += new EventHandler(this.ClearStatusBar_Leave);
            // 
            // labelProductName
            // 
            this.labelProductName.AccessibleDescription = "Show the product name";
            this.labelProductName.AccessibleName = "Product name";
            this.labelProductName.AccessibleRole = AccessibleRole.StaticText;
            this.labelProductName.AutoEllipsis = true;
            this.labelProductName.Dock = DockStyle.Fill;
            this.labelProductName.LiveSetting = AutomationLiveSetting.Polite;
            this.labelProductName.Location = new Point(51, 0);
            this.labelProductName.Margin = new Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new Size(186, 11);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product name";
            this.labelProductName.TextAlign = ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelProductName, "Product name");
            this.labelProductName.Enter += new EventHandler(this.SetStatusBar_Enter);
            this.labelProductName.Leave += new EventHandler(this.ClearStatusBar_Leave);
            this.labelProductName.MouseEnter += new EventHandler(this.SetStatusBar_Enter);
            this.labelProductName.MouseLeave += new EventHandler(this.ClearStatusBar_Leave);
            // 
            // labelVersion
            // 
            this.labelVersion.AccessibleDescription = "Show the version";
            this.labelVersion.AccessibleName = "Version";
            this.labelVersion.AccessibleRole = AccessibleRole.StaticText;
            this.labelVersion.AutoEllipsis = true;
            this.labelVersion.Dock = DockStyle.Fill;
            this.labelVersion.LiveSetting = AutomationLiveSetting.Polite;
            this.labelVersion.Location = new Point(51, 11);
            this.labelVersion.Margin = new Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new Size(186, 11);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelVersion, "Version");
            this.labelVersion.Enter += new EventHandler(this.SetStatusBar_Enter);
            this.labelVersion.Leave += new EventHandler(this.ClearStatusBar_Leave);
            this.labelVersion.MouseEnter += new EventHandler(this.SetStatusBar_Enter);
            this.labelVersion.MouseLeave += new EventHandler(this.ClearStatusBar_Leave);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AccessibleDescription = "Show the copyright";
            this.labelCopyright.AccessibleName = "Copyright";
            this.labelCopyright.AccessibleRole = AccessibleRole.StaticText;
            this.labelCopyright.AutoEllipsis = true;
            this.labelCopyright.Dock = DockStyle.Fill;
            this.labelCopyright.LiveSetting = AutomationLiveSetting.Polite;
            this.labelCopyright.Location = new Point(51, 22);
            this.labelCopyright.Margin = new Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new Size(186, 11);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelCopyright, "Copyright");
            this.labelCopyright.Enter += new EventHandler(this.SetStatusBar_Enter);
            this.labelCopyright.Leave += new EventHandler(this.ClearStatusBar_Leave);
            this.labelCopyright.MouseEnter += new EventHandler(this.SetStatusBar_Enter);
            this.labelCopyright.MouseLeave += new EventHandler(this.ClearStatusBar_Leave);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AccessibleDescription = "Show the company name";
            this.labelCompanyName.AccessibleName = "Company name";
            this.labelCompanyName.AccessibleRole = AccessibleRole.StaticText;
            this.labelCompanyName.AutoEllipsis = true;
            this.labelCompanyName.Dock = DockStyle.Fill;
            this.labelCompanyName.LiveSetting = AutomationLiveSetting.Polite;
            this.labelCompanyName.Location = new Point(51, 33);
            this.labelCompanyName.Margin = new Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new Size(186, 11);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "Company name";
            this.labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.labelCompanyName, "Copyright name");
            this.labelCompanyName.Enter += new EventHandler(this.SetStatusBar_Enter);
            this.labelCompanyName.Leave += new EventHandler(this.ClearStatusBar_Leave);
            this.labelCompanyName.MouseEnter += new EventHandler(this.SetStatusBar_Enter);
            this.labelCompanyName.MouseLeave += new EventHandler(this.ClearStatusBar_Leave);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AccessibleDescription = "Show the description";
            this.textBoxDescription.AccessibleName = "Description";
            this.textBoxDescription.AccessibleRole = AccessibleRole.Text;
            this.textBoxDescription.Dock = DockStyle.Fill;
            this.textBoxDescription.Location = new Point(51, 47);
            this.textBoxDescription.Margin = new Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = ScrollBars.Both;
            this.textBoxDescription.Size = new Size(186, 36);
            this.textBoxDescription.TabIndex = 4;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            this.toolTip.SetToolTip(this.textBoxDescription, "Description");
            this.textBoxDescription.Enter += new EventHandler(this.SetStatusBar_Enter);
            this.textBoxDescription.Leave += new EventHandler(this.ClearStatusBar_Leave);
            this.textBoxDescription.MouseEnter += new EventHandler(this.AboutBoxForm_Load);
            this.textBoxDescription.MouseLeave += new EventHandler(this.ClearStatusBar_Leave);
            // 
            // okButton
            // 
            this.okButton.AccessibleDescription = "Close the window";
            this.okButton.AccessibleName = "OK button";
            this.okButton.AccessibleRole = AccessibleRole.PushButton;
            this.okButton.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.okButton.AutoEllipsis = true;
            this.okButton.DialogResult = DialogResult.OK;
            this.okButton.ImageAlign = ContentAlignment.MiddleRight;
            this.okButton.Location = new Point(162, 90);
            this.okButton.Name = "okButton";
            this.okButton.Size = new Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "&OK";
            this.okButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.okButton.Enter += new EventHandler(this.SetStatusBar_Enter);
            this.okButton.Leave += new EventHandler(this.ClearStatusBar_Leave);
            this.okButton.MouseEnter += new EventHandler(this.SetStatusBar_Enter);
            this.okButton.MouseLeave += new EventHandler(this.ClearStatusBar_Leave);
            // 
            // statusStrip
            // 
            this.statusStrip.AccessibleDescription = "Show the status bar";
            this.statusStrip.AccessibleName = "status bar";
            this.statusStrip.AccessibleRole = AccessibleRole.StatusBar;
            this.statusStrip.AllowItemReorder = true;
            this.statusStrip.Dock = DockStyle.None;
            this.statusStrip.Items.AddRange(new ToolStripItem[] {
            this.labelInformation});
            this.statusStrip.Location = new Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new Size(240, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.TabStop = true;
            this.statusStrip.Text = "statusStrip";
            this.toolTip.SetToolTip(this.statusStrip, "Show the status bar");
            // 
            // labelInformation
            // 
            this.labelInformation.AccessibleDescription = "Show some information";
            this.labelInformation.AccessibleName = "some information";
            this.labelInformation.AccessibleRole = AccessibleRole.StaticText;
            this.labelInformation.AutoToolTip = true;
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new Size(28, 17);
            this.labelInformation.Text = "info";
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.AccessibleDescription = "Just a tool bar";
            this.toolStripContainer.AccessibleName = "tool bar";
            this.toolStripContainer.AccessibleRole = AccessibleRole.ToolBar;
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel);
            this.toolStripContainer.ContentPanel.Size = new Size(240, 116);
            this.toolStripContainer.Dock = DockStyle.Fill;
            this.toolStripContainer.Location = new Point(9, 9);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new Size(240, 163);
            this.toolStripContainer.TabIndex = 8;
            this.toolStripContainer.Text = "toolStripContainer";
            // 
            // AboutBoxForm
            // 
            this.AcceptButton = this.okButton;
            this.AccessibleDescription = "This is the program information window.";
            this.AccessibleName = "Program information";
            this.AccessibleRole = AccessibleRole.Dialog;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(258, 181);
            this.Controls.Add(this.toolStripContainer);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBoxForm";
            this.Padding = new Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Program information";
            this.Load += new EventHandler(this.AboutBoxForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private PictureBox logoPictureBox;
        private Label labelProductName;
        private Label labelVersion;
        private Label labelCopyright;
        private Label labelCompanyName;
        private TextBox textBoxDescription;
        private Button okButton;
        private ToolTip toolTip;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel labelInformation;
        private ToolStripContainer toolStripContainer;
    }
}
