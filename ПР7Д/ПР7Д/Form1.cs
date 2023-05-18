using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ПР7Д
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)

            {

                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);

                richTextBox1.Text = Reader.ReadToEnd();

                Reader.Close();

            }
            OpenDlg.Dispose();
        }

        public void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void ctrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)

                {

                    Writer.WriteLine((string)listBox2.Items[i]);

                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        public void выходAltXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },

            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)

            {

                string Str = s.Trim();



                if (Str == String.Empty) continue;

                if (radioButton1.Checked) listBox1.Items.Add(Str);

                if (radioButton2.Checked)

                {

                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);

                }

                if (radioButton3.Checked)

                {

                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);

                }

            }
            listBox1.EndUpdate();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = "i love shrimp";
            richTextBox1.Text = "i love shrimp";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Find = textBox1.Text;
            if (checkBox1.Checked)

            {

                foreach (string String in listBox1.Items)

                {

                    if (String.Contains(Find)) listBox3.Items.Add(String);

                }

            }
            if (checkBox2.Checked)

            {

                foreach (string String in listBox2.Items)

                {

                    if (String.Contains(Find)) listBox3.Items.Add(String);

                }

            }

        }

        public void button4_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;

            AddRec.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for(int i = listBox1.Items.Count -1;i>=0; i--)
            {
                if (listBox1.GetSelected(i)) listBox1.Items.RemoveAt(i);
            }
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (listBox2.GetSelected(i)) listBox2.Items.RemoveAt(i);
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "По алфавиту (по возрастанию)":
                    listBox1.Sorted = true;
                    break;

                case "По алфавиту (по убыванию)":
                    string[] Sort1;
                    Sort1 = new string[listBox1.Items.Count];
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        Sort1[i] = listBox1.Items[i].ToString();
                    }
                    Array.Reverse(Sort1);
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(Sort1);
                    break;

                case "По длине слов (по возрастанию)":
                    string[] Words2;
                    Words2 = new string[listBox1.Items.Count];
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        Words2[i] = listBox1.Items[i].ToString();
                    }
                    Words2 = Words2.OrderBy(x => x.Length).ToArray();
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(Words2);
                    break;

                case "По длине слов (по убыванию)":
                    string[] Words11;
                    Words11 = new string[listBox1.Items.Count];
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        Words11[i] = listBox1.Items[i].ToString();
                    }
                    Words11 = Words11.OrderBy(x => x.Length).ToArray();
                    Array.Reverse(Words11);
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(Words11);
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object Item in listBox1.SelectedItems)
            {

                listBox2.Items.Add(Item);
            }

            listBox1.EndUpdate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            foreach (object Item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(Item);
            }
            listBox2.EndUpdate();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);

            listBox1.Items.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);

            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

             private void button8_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "По алфавиту (по возрастанию)":
                    listBox2.Sorted = true;
                    break;

                case "По алфавиту (по убыванию)":
                    string[] Sort;
                    Sort = new string[listBox2.Items.Count];
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        Sort[i] = listBox2.Items[i].ToString();
                    }
                    Array.Reverse(Sort);
                    listBox2.Items.Clear();
                    listBox2.Items.AddRange(Sort);
                    break;

                case "По длине слов (по возрастанию)":
                    string[] Words;
                    Words = new string[listBox2.Items.Count];
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        Words[i] = listBox2.Items[i].ToString();
                    }
                    Words = Words.OrderBy(x => x.Length).ToArray();
                    listBox2.Items.Clear();
                    listBox2.Items.AddRange(Words);
                    break;

                case "По длине слов (по убыванию)":
                    string[] Words1;
                    Words1 = new string[listBox2.Items.Count];
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        Words1[i] = listBox2.Items[i].ToString();
                    }
                    Words1 = Words1.OrderBy(x => x.Length).ToArray();
                    Array.Reverse(Words1);
                    listBox2.Items.Clear();
                    listBox2.Items.AddRange(Words1);
                    break;
            }
        }
    }
}
