﻿
namespace CAN_Software
{
	partial class CANAnalyser
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
			this.tabController = new System.Windows.Forms.TabControl();
			this.analyserTab = new System.Windows.Forms.TabPage();
			this.debuggerTab = new System.Windows.Forms.TabPage();
			this.grapherTab = new System.Windows.Forms.TabPage();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
			this.makeSelection = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.tabController.SuspendLayout();
			this.analyserTab.SuspendLayout();
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
			this.menuStrip1.Size = new System.Drawing.Size(1898, 36);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 30);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
			this.viewToolStripMenuItem.Text = "View";
			this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 30);
			this.toolsToolStripMenuItem.Text = "Tools";
			this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 30);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// CANText
			// 
			this.CANText.EnableAutoDragDrop = true;
			this.CANText.Location = new System.Drawing.Point(8, 6);
			this.CANText.Name = "CANText";
			this.CANText.ReadOnly = true;
			this.CANText.Size = new System.Drawing.Size(486, 867);
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
			this.openButton.Location = new System.Drawing.Point(509, 128);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(75, 79);
			this.openButton.TabIndex = 3;
			this.openButton.Text = "open";
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(671, 128);
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
			this.portSelect.Location = new System.Drawing.Point(500, 25);
			this.portSelect.Name = "portSelect";
			this.portSelect.Size = new System.Drawing.Size(121, 28);
			this.portSelect.TabIndex = 5;
			this.portSelect.SelectedIndexChanged += new System.EventHandler(this.portSelect_SelectedIndexChanged);
			// 
			// baudSelect
			// 
			this.baudSelect.FormattingEnabled = true;
			this.baudSelect.Location = new System.Drawing.Point(500, 74);
			this.baudSelect.Name = "baudSelect";
			this.baudSelect.Size = new System.Drawing.Size(121, 28);
			this.baudSelect.TabIndex = 6;
			this.baudSelect.SelectedIndexChanged += new System.EventHandler(this.baudSelect_SelectedIndexChanged);
			// 
			// filterBox
			// 
			this.filterBox.Location = new System.Drawing.Point(800, 231);
			this.filterBox.Name = "filterBox";
			this.filterBox.Size = new System.Drawing.Size(114, 26);
			this.filterBox.TabIndex = 7;
			this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
			// 
			// filterButton
			// 
			this.filterButton.Location = new System.Drawing.Point(696, 225);
			this.filterButton.Name = "filterButton";
			this.filterButton.Size = new System.Drawing.Size(75, 38);
			this.filterButton.TabIndex = 8;
			this.filterButton.Text = "filter";
			this.filterButton.UseVisualStyleBackColor = true;
			this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
			// 
			// filterList
			// 
			this.filterList.Location = new System.Drawing.Point(509, 225);
			this.filterList.Multiline = true;
			this.filterList.Name = "filterList";
			this.filterList.Size = new System.Drawing.Size(172, 373);
			this.filterList.TabIndex = 9;
			this.filterList.TextChanged += new System.EventHandler(this.filterList_TextChanged);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(509, 604);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(172, 41);
			this.clearButton.TabIndex = 10;
			this.clearButton.Text = "clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// focusButton
			// 
			this.focusButton.Location = new System.Drawing.Point(696, 293);
			this.focusButton.Name = "focusButton";
			this.focusButton.Size = new System.Drawing.Size(75, 36);
			this.focusButton.TabIndex = 11;
			this.focusButton.Text = "focus";
			this.focusButton.UseVisualStyleBackColor = true;
			this.focusButton.Click += new System.EventHandler(this.focusButton_Click_1);
			// 
			// focusBox
			// 
			this.focusBox.Location = new System.Drawing.Point(800, 302);
			this.focusBox.Name = "focusBox";
			this.focusBox.Size = new System.Drawing.Size(114, 26);
			this.focusBox.TabIndex = 12;
			this.focusBox.TextChanged += new System.EventHandler(this.focusBox_TextChanged);
			// 
			// pauseButton
			// 
			this.pauseButton.Location = new System.Drawing.Point(590, 128);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(75, 79);
			this.pauseButton.TabIndex = 13;
			this.pauseButton.Text = "start  stop";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// tabController
			// 
			this.tabController.Controls.Add(this.analyserTab);
			this.tabController.Controls.Add(this.debuggerTab);
			this.tabController.Controls.Add(this.grapherTab);
			this.tabController.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabController.Location = new System.Drawing.Point(0, 36);
			this.tabController.Multiline = true;
			this.tabController.Name = "tabController";
			this.tabController.SelectedIndex = 0;
			this.tabController.Size = new System.Drawing.Size(1503, 988);
			this.tabController.TabIndex = 14;
			this.tabController.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// analyserTab
			// 
			this.analyserTab.Controls.Add(this.CANText);
			this.analyserTab.Controls.Add(this.pauseButton);
			this.analyserTab.Controls.Add(this.openButton);
			this.analyserTab.Controls.Add(this.focusBox);
			this.analyserTab.Controls.Add(this.closeButton);
			this.analyserTab.Controls.Add(this.focusButton);
			this.analyserTab.Controls.Add(this.portSelect);
			this.analyserTab.Controls.Add(this.clearButton);
			this.analyserTab.Controls.Add(this.baudSelect);
			this.analyserTab.Controls.Add(this.filterList);
			this.analyserTab.Controls.Add(this.filterBox);
			this.analyserTab.Controls.Add(this.filterButton);
			this.analyserTab.Dock = System.Windows.Forms.DockStyle.Fill;
			this.analyserTab.Location = new System.Drawing.Point(4, 29);
			this.analyserTab.Name = "analyserTab";
			this.analyserTab.Padding = new System.Windows.Forms.Padding(3);
			this.analyserTab.Size = new System.Drawing.Size(1495, 955);
			this.analyserTab.TabIndex = 0;
			this.analyserTab.Text = "Analyser";
			this.analyserTab.UseVisualStyleBackColor = true;
			this.analyserTab.Click += new System.EventHandler(this.analyserTab_Click);
			// 
			// debuggerTab
			// 
			this.debuggerTab.Location = new System.Drawing.Point(4, 29);
			this.debuggerTab.Name = "debuggerTab";
			this.debuggerTab.Padding = new System.Windows.Forms.Padding(3);
			this.debuggerTab.Size = new System.Drawing.Size(939, 635);
			this.debuggerTab.TabIndex = 1;
			this.debuggerTab.Text = "Debugger";
			this.debuggerTab.UseVisualStyleBackColor = true;
			this.debuggerTab.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// grapherTab
			// 
			this.grapherTab.Location = new System.Drawing.Point(4, 29);
			this.grapherTab.Name = "grapherTab";
			this.grapherTab.Padding = new System.Windows.Forms.Padding(3);
			this.grapherTab.Size = new System.Drawing.Size(939, 635);
			this.grapherTab.TabIndex = 2;
			this.grapherTab.Text = "Grapher";
			this.grapherTab.UseVisualStyleBackColor = true;
			// 
			// makeSelection
			// 
			this.makeSelection.FormattingEnabled = true;
			this.makeSelection.Location = new System.Drawing.Point(1749, 87);
			this.makeSelection.Name = "makeSelection";
			this.makeSelection.Size = new System.Drawing.Size(121, 28);
			this.makeSelection.TabIndex = 15;
			this.makeSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// CANAnalyser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1898, 1024);
			this.Controls.Add(this.makeSelection);
			this.Controls.Add(this.tabController);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.HelpButton = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "CANAnalyser";
			this.Text = "CANAnalyser";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabController.ResumeLayout(false);
			this.analyserTab.ResumeLayout(false);
			this.analyserTab.PerformLayout();
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
		private System.Windows.Forms.TabControl tabController;
		private System.Windows.Forms.TabPage analyserTab;
		private System.Windows.Forms.TabPage debuggerTab;
		private System.Windows.Forms.TabPage grapherTab;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.DirectoryServices.DirectoryEntry directoryEntry1;
		private System.Windows.Forms.ComboBox makeSelection;
	}
}

