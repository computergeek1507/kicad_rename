using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kicad_rename
{
    public partial class Form1 : Form
    {
        public static ListBoxLog listBoxLog;
        public Form1()
        {
            InitializeComponent();
            listBoxLog = new ListBoxLog(listBox1);
        }

        private void buttonProject_Click(object sender, EventArgs e)
        {
            if (openFileDialogProject.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogProject.FileName;
                textBoxProject.Text = filePath;
                //FileInfo info = new FileInfo(filePath);
                textBoxNewName.Text = textBoxOldName.Text = System.IO.Path.GetFileNameWithoutExtension(filePath);
            } 
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            FileInfo project = new FileInfo(textBoxProject.Text);
            if (!project.Exists)
            {
                MessageBox.Show("File Doesn't Exists");
                return;
            }
            if (textBoxNewName.Text == textBoxOldName.Text)
            {
                MessageBox.Show("New and Old Names Are the same");
                return;
            }
            foreach (string fileName in Directory.GetFiles(project.Directory.FullName))
            {
                // fileName  is the file name
                string newName = fileName.Replace(textBoxOldName.Text, textBoxNewName.Text);
                if (fileName == newName)
                    continue;
                try
                {
                    FileInfo newFile = new FileInfo(newName);

                    if (!newFile.Directory.Exists)
                    {
                        newFile.Directory.Create();
                        //Directory.CreateDirectory(path);
                    }


                    if (checkBoxCopy.Checked)
                    {
                        File.Copy(fileName, newName);
                    }
                    else
                    {
                        File.Move(fileName, newName);
                    }
                    Thread.Sleep(100);
                    ReplaceInFile(newName, textBoxOldName.Text, textBoxNewName.Text);
                }
                catch (Exception ex)
                {
                    listBoxLog.Log(Level.Error, ex.Message);
                }
            }


            foreach (string folderName in Directory.GetDirectories(project.Directory.FullName))
            {
                try
                {
                    // folderName  is the folder name
                    string newFolder = folderName.Replace(textBoxOldName.Text, textBoxNewName.Text);
                    if (folderName == newFolder)
                        continue;
                    DirectoryInfo newFile = new DirectoryInfo(newFolder);

                    var diSource = new DirectoryInfo(folderName);
                    var diTarget = new DirectoryInfo(newFolder);

                    if (checkBoxCopy.Checked)
                    {
                        CopyAll(diSource, diTarget);
                    }
                    else
                    {
                        MoveAll(diSource, diTarget);
                    }
  
                }
                catch (Exception ex)
                {
                    listBoxLog.Log(Level.Error, ex.Message);
                }
            }

        }

        void ReplaceInFile(string filePath, string searchText, string replaceText)
        {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, replaceText);

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();
        }

        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                listBoxLog.Log(Level.Debug, string.Format(@"Copying {0}\{1}", target.FullName, fi.Name));
                //Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        public void MoveAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                listBoxLog.Log(Level.Debug,string.Format(@"Moving {0}\{1}", target.FullName, fi.Name));

                //Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.MoveTo(Path.Combine(target.FullName, fi.Name));
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                MoveAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void buttonSchematic_Click(object sender, EventArgs e)
        {
            if (openFileDialogSchematic.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogSchematic.FileName;
                textBoxSchematic.Text = filePath;
                //FileInfo info = new FileInfo(filePath);
            }            
        }

        private void buttonSixFix_Click(object sender, EventArgs e)
        {

        }
    }
}
