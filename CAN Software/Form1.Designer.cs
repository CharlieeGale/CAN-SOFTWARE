
namespace CAN_Software
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CANText = new System.Windows.Forms.RichTextBox();
			this.serialPort = new System.IO.Ports.SerialPort(this.components);
			this.openButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.portSelect = new System.Windows.Forms.ComboBox();
			this.baudSelect = new System.Windows.Forms.ComboBox();
			this.filterBox = new System.Windows.Forms.TextBox();
			this.filterButton = new System.Windows.Forms.Button();
			this.filterList = new System.Windows.Forms.TextBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.focusButton = new System.Windows.Forms.Button();
			this.focusBox = new System.Windows.Forms.TextBox();
			this.pauseButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1898, 33);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// CANText
			// 
			this.CANText.EnableAutoDragDrop = true;
			this.CANText.Location = new System.Drawing.Point(13, 37);
			this.CANText.Name = "CANText";
			this.CANText.ReadOnly = true;
			this.CANText.Size = new System.Drawing.Size(486, 975);
			this.CANText.TabIndex = 2;
			this.CANText.Text = "";
			this.CANText.TextChanged += new System.EventHandler(this.CANText_TextChanged);
			// 
			// serialPort
			// 
			this.serialPort.BaudRate = 500000;
			this.serialPort.PortName = "COM4";
			// 
			// openButton
			// 
			this.openButton.Location = new System.Drawing.Point(514, 159);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(75, 79);
			this.openButton.TabIndex = 3;
			this.openButton.Text = "open";
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(676, 159);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 79);
			this.closeButton.TabIndex = 4;
			this.closeButton.Text = "close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// portSelect
			// 
			this.portSelect.FormattingEnabled = true;
			this.portSelect.Location = new System.Drawing.Point(505, 56);
			this.portSelect.Name = "portSelect";
			this.portSelect.Size = new System.Drawing.Size(121, 28);
			this.portSelect.TabIndex = 5;
			// 
			// baudSelect
			// 
			this.baudSelect.FormattingEnabled = true;
			this.baudSelect.Location = new System.Drawing.Point(505, 105);
			this.baudSelect.Name = "baudSelect";
			this.baudSelect.Size = new System.Drawing.Size(121, 28);
			this.baudSelect.TabIndex = 6;
			// 
			// filterBox
			// 
			this.filterBox.Location = new System.Drawing.Point(805, 262);
			this.filterBox.Name = "filterBox";
			this.filterBox.Size = new System.Drawing.Size(114, 26);
			this.filterBox.TabIndex = 7;
			this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
			// 
			// filterButton
			// 
			this.filterButton.Location = new System.Drawing.Point(701, 256);
			this.filterButton.Name = "filterButton";
			this.filterButton.Size = new System.Drawing.Size(75, 38);
			this.filterButton.TabIndex = 8;
			this.filterButton.Text = "filter";
			this.filterButton.UseVisualStyleBackColor = true;
			this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
			// 
			// filterList
			// 
			this.filterList.Location = new System.Drawing.Point(514, 256);
			this.filterList.Multiline = true;
			this.filterList.Name = "filterList";
			this.filterList.Size = new System.Drawing.Size(172, 373);
			this.filterList.TabIndex = 9;
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(514, 635);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(172, 41);
			this.clearButton.TabIndex = 10;
			this.clearButton.Text = "clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// focusButton
			// 
			this.focusButton.Location = new System.Drawing.Point(701, 324);
			this.focusButton.Name = "focusButton";
			this.focusButton.Size = new System.Drawing.Size(75, 36);
			this.focusButton.TabIndex = 11;
			this.focusButton.Text = "focus";
			this.focusButton.UseVisualStyleBackColor = true;
			// 
			// focusBox
			// 
			this.focusBox.Location = new System.Drawing.Point(805, 333);
			this.focusBox.Name = "focusBox";
			this.focusBox.Size = new System.Drawing.Size(114, 26);
			this.focusBox.TabIndex = 12;
			this.focusBox.TextChanged += new System.EventHandler(this.focusBox_TextChanged);
			// 
			// pauseButton
			// 
			this.pauseButton.Location = new System.Drawing.Point(595, 159);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(75, 79);
			this.pauseButton.TabIndex = 13;
			this.pauseButton.Text = "start  stop";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1898, 1024);
			this.Controls.Add(this.pauseButton);
			this.Controls.Add(this.focusBox);
			this.Controls.Add(this.focusButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.filterList);
			this.Controls.Add(this.filterButton);
			this.Controls.Add(this.filterBox);
			this.Controls.Add(this.baudSelect);
			this.Controls.Add(this.portSelect);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.openButton);
			this.Controls.Add(this.CANText);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "CANAnalyser";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.RichTextBox CANText;
		public System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.ComboBox portSelect;
		private System.Windows.Forms.ComboBox baudSelect;
		private System.Windows.Forms.TextBox filterBox;
		private System.Windows.Forms.Button filterButton;
		private System.Windows.Forms.TextBox filterList;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button focusButton;
		private System.Windows.Forms.TextBox focusBox;
		private System.Windows.Forms.Button pauseButton;
	}
}

