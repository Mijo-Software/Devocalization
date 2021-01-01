
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.groupBoxInput = new System.Windows.Forms.GroupBox();
			this.buttonDevocalize = new System.Windows.Forms.Button();
			this.groupBoxOutput = new System.Windows.Forms.GroupBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.groupBoxInput.SuspendLayout();
			this.groupBoxOutput.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxInput
			// 
			this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxInput.Location = new System.Drawing.Point(3, 16);
			this.textBoxInput.MaxLength = 9999999;
			this.textBoxInput.Multiline = true;
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(250, 100);
			this.textBoxInput.TabIndex = 0;
			this.textBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
			// 
			// groupBoxInput
			// 
			this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxInput.Controls.Add(this.textBoxInput);
			this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
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
			this.buttonDevocalize.Enabled = false;
			this.buttonDevocalize.Location = new System.Drawing.Point(15, 137);
			this.buttonDevocalize.Name = "buttonDevocalize";
			this.buttonDevocalize.Size = new System.Drawing.Size(250, 23);
			this.buttonDevocalize.TabIndex = 2;
			this.buttonDevocalize.Text = "Devocalize";
			this.buttonDevocalize.UseVisualStyleBackColor = true;
			this.buttonDevocalize.Click += new System.EventHandler(this.ButtonDevocalize_Click);
			// 
			// groupBoxOutput
			// 
			this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxOutput.Controls.Add(this.textBoxOutput);
			this.groupBoxOutput.Location = new System.Drawing.Point(15, 166);
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
			this.textBoxOutput.MaxLength = 9999999;
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.Size = new System.Drawing.Size(250, 100);
			this.textBoxOutput.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 289);
			this.Controls.Add(this.groupBoxOutput);
			this.Controls.Add(this.buttonDevocalize);
			this.Controls.Add(this.groupBoxInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Devocalization";
			this.groupBoxInput.ResumeLayout(false);
			this.groupBoxInput.PerformLayout();
			this.groupBoxOutput.ResumeLayout(false);
			this.groupBoxOutput.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.GroupBox groupBoxInput;
		private System.Windows.Forms.Button buttonDevocalize;
		private System.Windows.Forms.GroupBox groupBoxOutput;
		private System.Windows.Forms.TextBox textBoxOutput;
	}
}

