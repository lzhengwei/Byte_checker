using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytw_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string intput_file_name = "";
        private void button_openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "選擇要開啟的檔案";
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {               
                textBox_open.Text = openFileDialog1.FileName;
                intput_file_name=textBox_open.Text;
            }
        }
        private string get_byte_process(string input_file_path)
        {
            FileStream stream = File.OpenRead(input_file_path);

            int b = 0, idx=0;
            StringBuilder sb = new StringBuilder();
            while ((b = stream.ReadByte()) > -1)
            {
                if (idx % 8 == 0)
                {
                    sb.Append(Environment.NewLine);
                    //output_file.WriteLine(sb.ToString());
                    //sb.Clear();                 
                }               
                sb.Append(string.Format("data[{0}]={1} ", idx.ToString().PadLeft(4, '0'), Convert.ToString(b, 16).PadLeft(2, '0')));
                idx++;
            }
            return sb.ToString();
        }
        private string Filename_process(string FilePath)
        {
            return Path.GetFileNameWithoutExtension(FilePath)+"_bytes.txt";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "選擇要儲存的檔案";
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_save.Text = openFileDialog1.FileName;
                outputfile_process(intput_file_name, openFileDialog1.FileName);
            }
        }
        private void outputfile_process(string intput_file_path,string output_file_path)
        {
            StreamWriter output_file;
            if (!File.Exists(output_file_path))
            {
                output_file = File.CreateText(output_file_path);
            }
            else
            {
                output_file = new StreamWriter(output_file_path);
            }
            output_file.WriteLine(get_byte_process(intput_file_path));
            output_file.Close();
        }
    }
}
