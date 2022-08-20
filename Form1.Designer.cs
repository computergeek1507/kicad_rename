namespace kicad_rename
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxProject = new System.Windows.Forms.TextBox();
			this.textBoxOldName = new System.Windows.Forms.TextBox();
			this.textBoxNewName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonProject = new System.Windows.Forms.Button();
			this.buttonRename = new System.Windows.Forms.Button();
			this.openFileDialogProject = new System.Windows.Forms.OpenFileDialog();
			this.checkBoxCopy = new System.Windows.Forms.CheckBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.buttonSixFix = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxSchematic = new System.Windows.Forms.TextBox();
			this.buttonSchematic = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.openFileDialogSchematicPCB = new System.Windows.Forms.OpenFileDialog();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.buttonPCBRun = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxPCBPath = new System.Windows.Forms.TextBox();
			this.buttonPCBSelect = new System.Windows.Forms.Button();
			this.openFileDialogSchematic = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialogPCB = new System.Windows.Forms.OpenFileDialog();
			this.dataGridViewReplace = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReplace)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Project:";
			// 
			// textBoxProject
			// 
			this.textBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxProject.Location = new System.Drawing.Point(74, 8);
			this.textBoxProject.Name = "textBoxProject";
			this.textBoxProject.Size = new System.Drawing.Size(634, 20);
			this.textBoxProject.TabIndex = 1;
			// 
			// textBoxOldName
			// 
			this.textBoxOldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOldName.Location = new System.Drawing.Point(74, 34);
			this.textBoxOldName.Name = "textBoxOldName";
			this.textBoxOldName.Size = new System.Drawing.Size(634, 20);
			this.textBoxOldName.TabIndex = 2;
			// 
			// textBoxNewName
			// 
			this.textBoxNewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxNewName.Location = new System.Drawing.Point(74, 60);
			this.textBoxNewName.Name = "textBoxNewName";
			this.textBoxNewName.Size = new System.Drawing.Size(634, 20);
			this.textBoxNewName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Old Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "New Name:";
			// 
			// buttonProject
			// 
			this.buttonProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonProject.Location = new System.Drawing.Point(713, 6);
			this.buttonProject.Name = "buttonProject";
			this.buttonProject.Size = new System.Drawing.Size(40, 21);
			this.buttonProject.TabIndex = 6;
			this.buttonProject.Text = "...";
			this.buttonProject.UseVisualStyleBackColor = true;
			this.buttonProject.Click += new System.EventHandler(this.buttonProject_Click);
			// 
			// buttonRename
			// 
			this.buttonRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRename.Location = new System.Drawing.Point(617, 84);
			this.buttonRename.Name = "buttonRename";
			this.buttonRename.Size = new System.Drawing.Size(90, 25);
			this.buttonRename.TabIndex = 7;
			this.buttonRename.Text = "Rename";
			this.buttonRename.UseVisualStyleBackColor = true;
			this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
			// 
			// openFileDialogProject
			// 
			this.openFileDialogProject.Filter = "Kicad files (*.pro;*.kicad_pro)|*.pro;*.kicad_pro|All Files|*.*";
			this.openFileDialogProject.RestoreDirectory = true;
			this.openFileDialogProject.Title = "Select Project";
			// 
			// checkBoxCopy
			// 
			this.checkBoxCopy.AutoSize = true;
			this.checkBoxCopy.Checked = true;
			this.checkBoxCopy.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCopy.Location = new System.Drawing.Point(80, 89);
			this.checkBoxCopy.Name = "checkBoxCopy";
			this.checkBoxCopy.Size = new System.Drawing.Size(74, 17);
			this.checkBoxCopy.TabIndex = 8;
			this.checkBoxCopy.Text = "Copy Files";
			this.checkBoxCopy.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(9, 10);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(766, 343);
			this.tabControl1.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.checkBoxCopy);
			this.tabPage1.Controls.Add(this.textBoxProject);
			this.tabPage1.Controls.Add(this.buttonRename);
			this.tabPage1.Controls.Add(this.textBoxOldName);
			this.tabPage1.Controls.Add(this.buttonProject);
			this.tabPage1.Controls.Add(this.textBoxNewName);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Size = new System.Drawing.Size(758, 317);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Rename Project";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridViewReplace);
			this.tabPage2.Controls.Add(this.buttonSixFix);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.textBoxSchematic);
			this.tabPage2.Controls.Add(this.buttonSchematic);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Size = new System.Drawing.Size(758, 317);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Text Replace";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// buttonSixFix
			// 
			this.buttonSixFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSixFix.Location = new System.Drawing.Point(640, 29);
			this.buttonSixFix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonSixFix.Name = "buttonSixFix";
			this.buttonSixFix.Size = new System.Drawing.Size(69, 29);
			this.buttonSixFix.TabIndex = 12;
			this.buttonSixFix.Text = "Run";
			this.buttonSixFix.UseVisualStyleBackColor = true;
			this.buttonSixFix.Click += new System.EventHandler(this.buttonSixFix_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "PCB/Schematic:";
			// 
			// textBoxSchematic
			// 
			this.textBoxSchematic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSchematic.Location = new System.Drawing.Point(97, 6);
			this.textBoxSchematic.Name = "textBoxSchematic";
			this.textBoxSchematic.Size = new System.Drawing.Size(613, 20);
			this.textBoxSchematic.TabIndex = 8;
			// 
			// buttonSchematic
			// 
			this.buttonSchematic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSchematic.Location = new System.Drawing.Point(715, 4);
			this.buttonSchematic.Name = "buttonSchematic";
			this.buttonSchematic.Size = new System.Drawing.Size(40, 21);
			this.buttonSchematic.TabIndex = 11;
			this.buttonSchematic.Text = "...";
			this.buttonSchematic.UseVisualStyleBackColor = true;
			this.buttonSchematic.Click += new System.EventHandler(this.buttonSchematic_Click);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(9, 357);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(767, 95);
			this.listBox1.TabIndex = 10;
			// 
			// openFileDialogSchematicPCB
			// 
			this.openFileDialogSchematicPCB.Filter = "Kicad 6 Files (*.kicad_sch;*.kicad_pcb)|*.kicad_sch;*.kicad_pcb|All Files|*.*";
			this.openFileDialogSchematicPCB.RestoreDirectory = true;
			this.openFileDialogSchematicPCB.Title = "Select Kicad 6 Schematic/PCB";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.buttonPCBRun);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.textBoxPCBPath);
			this.tabPage3.Controls.Add(this.buttonPCBSelect);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(758, 317);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "PCB 6 Footprint Finder";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(758, 317);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "PartNumber Finder";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// buttonPCBRun
			// 
			this.buttonPCBRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPCBRun.Location = new System.Drawing.Point(638, 33);
			this.buttonPCBRun.Margin = new System.Windows.Forms.Padding(2);
			this.buttonPCBRun.Name = "buttonPCBRun";
			this.buttonPCBRun.Size = new System.Drawing.Size(69, 29);
			this.buttonPCBRun.TabIndex = 16;
			this.buttonPCBRun.Text = "Run";
			this.buttonPCBRun.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "PCB:";
			// 
			// textBoxPCBPath
			// 
			this.textBoxPCBPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPCBPath.Location = new System.Drawing.Point(40, 10);
			this.textBoxPCBPath.Name = "textBoxPCBPath";
			this.textBoxPCBPath.Size = new System.Drawing.Size(668, 20);
			this.textBoxPCBPath.TabIndex = 14;
			// 
			// buttonPCBSelect
			// 
			this.buttonPCBSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPCBSelect.Location = new System.Drawing.Point(713, 8);
			this.buttonPCBSelect.Name = "buttonPCBSelect";
			this.buttonPCBSelect.Size = new System.Drawing.Size(40, 21);
			this.buttonPCBSelect.TabIndex = 15;
			this.buttonPCBSelect.Text = "...";
			this.buttonPCBSelect.UseVisualStyleBackColor = true;
			// 
			// openFileDialogSchematic
			// 
			this.openFileDialogSchematic.Filter = "Kicad 6 Schematic Files (*.kicad_sch)|*.kicad_sch|All Files|*.*";
			this.openFileDialogSchematic.RestoreDirectory = true;
			this.openFileDialogSchematic.Title = "Select Kicad 6 Schematic";
			// 
			// openFileDialogPCB
			// 
			this.openFileDialogPCB.Filter = "Kicad 6 PCB Files (*.kicad_pcb)|*.kicad_pcb|All Files|*.*";
			this.openFileDialogPCB.RestoreDirectory = true;
			this.openFileDialogPCB.Title = "Select Kicad 6 PCB";
			// 
			// dataGridViewReplace
			// 
			this.dataGridViewReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewReplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReplace.Location = new System.Drawing.Point(8, 69);
			this.dataGridViewReplace.Name = "dataGridViewReplace";
			this.dataGridViewReplace.Size = new System.Drawing.Size(745, 243);
			this.dataGridViewReplace.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 466);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.tabControl1);
			this.MinimumSize = new System.Drawing.Size(332, 154);
			this.Name = "Form1";
			this.Text = "Kicad Tools";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReplace)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.TextBox textBoxOldName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonProject;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.OpenFileDialog openFileDialogProject;
        private System.Windows.Forms.CheckBox checkBoxCopy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSixFix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSchematic;
        private System.Windows.Forms.Button buttonSchematic;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialogSchematicPCB;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button buttonPCBRun;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxPCBPath;
		private System.Windows.Forms.Button buttonPCBSelect;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.OpenFileDialog openFileDialogSchematic;
		private System.Windows.Forms.OpenFileDialog openFileDialogPCB;
		private System.Windows.Forms.DataGridView dataGridViewReplace;
	}
}

