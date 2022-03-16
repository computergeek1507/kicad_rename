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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSchematic = new System.Windows.Forms.TextBox();
            this.buttonSchematic = new System.Windows.Forms.Button();
            this.buttonSixFix = new System.Windows.Forms.Button();
            this.openFileDialogSchematic = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project:";
            // 
            // textBoxProject
            // 
            this.textBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProject.Location = new System.Drawing.Point(99, 10);
            this.textBoxProject.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(844, 22);
            this.textBoxProject.TabIndex = 1;
            // 
            // textBoxOldName
            // 
            this.textBoxOldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOldName.Location = new System.Drawing.Point(99, 42);
            this.textBoxOldName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOldName.Name = "textBoxOldName";
            this.textBoxOldName.Size = new System.Drawing.Size(844, 22);
            this.textBoxOldName.TabIndex = 2;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewName.Location = new System.Drawing.Point(99, 74);
            this.textBoxNewName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(844, 22);
            this.textBoxNewName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Old Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Name:";
            // 
            // buttonProject
            // 
            this.buttonProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProject.Location = new System.Drawing.Point(951, 8);
            this.buttonProject.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProject.Name = "buttonProject";
            this.buttonProject.Size = new System.Drawing.Size(53, 26);
            this.buttonProject.TabIndex = 6;
            this.buttonProject.Text = "...";
            this.buttonProject.UseVisualStyleBackColor = true;
            this.buttonProject.Click += new System.EventHandler(this.buttonProject_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRename.Location = new System.Drawing.Point(823, 104);
            this.buttonRename.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(120, 31);
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
            this.checkBoxCopy.Location = new System.Drawing.Point(107, 110);
            this.checkBoxCopy.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCopy.Name = "checkBoxCopy";
            this.checkBoxCopy.Size = new System.Drawing.Size(93, 20);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 309);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rename Project";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSixFix);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxSchematic);
            this.tabPage2.Controls.Add(this.buttonSchematic);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Schematic 6 Fixer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 327);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1021, 228);
            this.listBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Schematic:";
            // 
            // textBoxSchematic
            // 
            this.textBoxSchematic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSchematic.Location = new System.Drawing.Point(88, 7);
            this.textBoxSchematic.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSchematic.Name = "textBoxSchematic";
            this.textBoxSchematic.Size = new System.Drawing.Size(857, 22);
            this.textBoxSchematic.TabIndex = 8;
            // 
            // buttonSchematic
            // 
            this.buttonSchematic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSchematic.Location = new System.Drawing.Point(953, 5);
            this.buttonSchematic.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSchematic.Name = "buttonSchematic";
            this.buttonSchematic.Size = new System.Drawing.Size(53, 26);
            this.buttonSchematic.TabIndex = 11;
            this.buttonSchematic.Text = "...";
            this.buttonSchematic.UseVisualStyleBackColor = true;
            this.buttonSchematic.Click += new System.EventHandler(this.buttonSchematic_Click);
            // 
            // buttonSixFix
            // 
            this.buttonSixFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSixFix.Location = new System.Drawing.Point(853, 36);
            this.buttonSixFix.Name = "buttonSixFix";
            this.buttonSixFix.Size = new System.Drawing.Size(92, 36);
            this.buttonSixFix.TabIndex = 12;
            this.buttonSixFix.Text = "Run";
            this.buttonSixFix.UseVisualStyleBackColor = true;
            this.buttonSixFix.Click += new System.EventHandler(this.buttonSixFix_Click);
            // 
            // openFileDialogSchematic
            // 
            this.openFileDialogSchematic.Filter = "Kicad 6 Schematic Files (*.kicad_sch)|*.kicad_sch|All Files|*.*";
            this.openFileDialogSchematic.RestoreDirectory = true;
            this.openFileDialogSchematic.Title = "Select Kicad 6 Schematic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 574);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(437, 180);
            this.Name = "Form1";
            this.Text = "Kicad Tools";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog openFileDialogSchematic;
    }
}

