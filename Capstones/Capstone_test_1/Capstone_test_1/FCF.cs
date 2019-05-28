using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace Capstone_test_1
{
    public partial class FCF : Form
    {
        public FCF()
        {
            InitializeComponent();
            comboBox1.Items.Add("*.txt");
            comboBox1.Items.Add("*.jpg");
            comboBox1.Items.Add("*.mp3");
            comboBox1.Items.Add("*.mp4");
            comboBox1.Items.Add("*.*");
            comboBox1.Items.Add("*.pdf");
            comboBox1.Items.Add("*.hwp");
            comboBox1.Items.Add("*.zip");
        }

        private void Open_file_click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
        
        public void ChooseFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }
        public void ChooseFolder2()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fbd.SelectedPath;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ChooseFolder2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String extension = comboBox1.SelectedItem.ToString();
            String srcDir = textBox1.Text;
            String DestDir = textBox3.Text;
            DateTime st = starttimepicker.Value;
            DateTime ed = endtimepicker.Value;
            DirectoryInfo dir = new DirectoryInfo($"{srcDir}");
            FileInfo[] files = dir.GetFiles($"{extension}", SearchOption.AllDirectories);

            Regex regex = new Regex(textBox4.Text);
            if (DateTime.Compare(st, ed) > 0)
                MessageBox.Show("End Time is earlier than Start Time\r\nPlease Resetting Time");
            foreach (FileInfo file in files)
            {
                String fileName = file.Name.Replace(extension, "");
                if (regex.IsMatch(fileName)&&DateTime.Compare(st,ed)<0&&(DateTime.Compare(st,file.CreationTime)<0||
                    DateTime.Compare(st, file.LastAccessTime)<0|| DateTime.Compare(st, file.LastWriteTime)<0||
                    DateTime.Compare(file.CreationTime,ed)>0|| DateTime.Compare(file.LastAccessTime, ed) > 0||
                    DateTime.Compare(file.LastWriteTime, ed) > 0))
                {
                  
                    textBox3.AppendText(file.FullName+Environment.NewLine);
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
        private void endtime_ValueChanged(object sender, EventArgs e)
        {
            DateTime ed = endtimepicker.Value;
        }
        private void starttimepicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime st = starttimepicker.Value;
        }
        private void TimeFiltering_Click(object sender, EventArgs e)
        {
            String extension = comboBox1.SelectedItem.ToString();
            String srcDir = textBox1.Text;
            String DestDir = textBox2.Text;
            DateTime st = starttimepicker.Value;
            DateTime ed = endtimepicker.Value;
            DirectoryInfo dir = new DirectoryInfo($"{srcDir}");
            FileInfo[] files = dir.GetFiles($"{extension}", SearchOption.AllDirectories);

            Regex regex = new Regex(textBox4.Text);
            foreach (FileInfo file in files)
            {
                String fileName = file.Name.Replace(extension, "");
                if (regex.IsMatch(fileName) && DateTime.Compare(st, ed) < 0 && (DateTime.Compare(st, file.CreationTime) < 0 ||
                    DateTime.Compare(st, file.LastAccessTime) < 0 || DateTime.Compare(st, file.LastWriteTime) < 0 ||
                    DateTime.Compare(file.CreationTime, ed) > 0 || DateTime.Compare(file.LastAccessTime, ed) > 0 ||
                    DateTime.Compare(file.LastWriteTime, ed) > 0))
                {
                    string sourceFile = file.FullName;
                    string destFile = Path.Combine(DestDir, fileName);
                    System.IO.Directory.CreateDirectory(srcDir);
                    System.IO.File.Copy(sourceFile, destFile, true);

                   
                }
            }
            SaveLog();
            System.Diagnostics.Process.Start(textBox2.Text);
        }
        public void SaveLog()
        {/*
             
            StreamWriter sw;
            sw = new StreamWriter(Path.Combine(textBox2.Text,"Log.txt"));
            sw.Write("수집시간 : "+DateTime.Now+ Environment.NewLine);
            string texts = textBox3.Text;
            sw.Write(texts);
            
            sw.Close();
            */
            using (StreamWriter sw = new StreamWriter(Path.Combine(textBox2.Text, "Log.txt")))
            {
                sw.Write("수집시간 : " + DateTime.Now + Environment.NewLine);
                string texts = textBox3.Text;
                sw.Write(texts);
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ScrollBars = ScrollBars.Vertical;
            // Allow the TAB key to be entered in the TextBox control.
            textBox3.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            textBox3.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            textBox3.WordWrap = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }
}
