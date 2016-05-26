using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace mt_emulyator
{
    public partial class Form1 : Form
    {
        public Label[] list1;
        public Label[] list2;
        public ListBox listBox1;
        public int[] maxIt = new int[Program.M+1];
        public Form1()
        {
            InitializeComponent();
        }

        public void lentsFull()
        {
            list1 = new Label[100];
            list2 = new Label[100];
            this.Controls.Add(lent1);
            this.Controls.Add(lent2);
            for (int i = 0; i < 100; i++)
            {
                Label l1 = new Label();
                l1.Text = "λ";
                l1.Font = new Font("Arial", 13);
                l1.Location = new Point(i * 20 - 2, 0);
                l1.Size = new Size(20, 24);
                l1.BorderStyle = BorderStyle.FixedSingle;
                Label l2 = new Label();
                l2.Text = "λ";
                l2.Font = new Font("Arial", 13);
                l2.Location = new Point(i * 20 - 2, 0);
                l2.Size = new Size(20, 24);
                l2.BorderStyle = BorderStyle.FixedSingle; 
                list1[i] = l1;
                list2[i] = l2; 
            }
            lent1.Controls.AddRange(list1);
            lent2.Controls.AddRange(list2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = new string[100];
            lines = File.ReadAllLines("mtn.txt");
            int num;
            num = lines.Length;
            string[] dislines = new string[5];
            char[] delim = new char[] { ' ' };

            for (int i = 0; i < num; i++)
            {
                this.mtTable.Rows.Add();
            }

            for (int i = 0; i < num; i++)
            {
                dislines = lines[i].Split(delim);
                for (int j = 0; j < 8; j++)
                    mtTable.Rows[i].Cells[j].Value = dislines[j];
            }
            mtTable.Rows[0].Cells[0].Selected = false;
            lentsFull();
        }
        // graph
        private void button3_Click(object sender, EventArgs e) 
        {
            listBox1 = new ListBox();
            status.Text = "Генерация и анализ слов...";
            // generate words
            char[] s = new char[Program.M];
            for (int i = 1; i <= Program.M; i++)
                Program.rec(i, 0, s);
            // check words
            string w;
            int iter=0;
            for (int i = 0; i < maxIt.Length; i++)
                maxIt[i] = 0;

            for (int j = 0; j < listBox1.Items.Count; j++)
            {
                w = listBox1.Items[j].ToString();
                for (int i = 0; i < list1.Length; i++)
                    list1[i].Text = "λ";
                for (int i = 0; i < list2.Length; i++)
                    list2[i].Text = "λ";
                for (int i = 0; i < w.Length; i++)
                    list1[i + 3].Text = w[i].ToString();

                iter = Program.check(0);
                if (maxIt[w.Length] < iter)
                    maxIt[w.Length] = iter;
            }
            Graphic GrForm = new Graphic();
            GrForm.Show();
            maxIt[0] = 2;
            GrForm.DrawGraph(Program.M, maxIt);
            status.Text = "Ожидание начала работы программы";
        }

        private void button1_Click(object sender, EventArgs e) // start mt
        {
            if (textBox1.Text.Length == 0)
            {
                char[] arr = new char[3];

            }
            else
            {
                Program.stop = false;
                Program.pause = false;
                CountSteps.Text = "Выполнено шагов: 0";
            } 
                status.Text = "Программа работает...";
                Refresh();
                Program.check(1);
        }
        //clean
        private void button2_Click(object sender, EventArgs e) 
        {
            listBox3.Items.Clear(); 
            for (int i = 0;  i<list1.Length; i++)
                list1[i].Text = "λ"; 
            for (int i = 0; i<list2.Length; i++)
                list2[i].Text = "λ";
            textBox1.Text = "";
            CountSteps.Text = "Выполнено шагов: 0";
            status.Text = "Ожидание начала работы программы...";
            Program.stop = false;
            Program.pause = false;
        }

        private void sw_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Program.stop = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Program.pause) Program.pause = true;
            else Program.pause = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveDialog.Filter = "(*.txt)|*.txt";
            SaveDialog.FileName = "mt_out1.txt";
            SaveDialog.Title = "Сохранение результатов работы МТ";
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.CreateText(SaveDialog.FileName); 
                foreach (string s in this.listBox3.Items)
                    sw.WriteLine(s);
                sw.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           string s = textBox1.Text;
           int i = 0;   
               for (i = 0; i < s.Length; i++ )
                   if (( i==0 && s.Length==0 )|| s[i] == '1' || s[i] == '0') list1[i + 3].Text = Convert.ToString(s[i]);
                   else 
                   {
                       MessageBox.Show("Не корректный ввод данных");
                       textBox1.Clear();
                   }
               if (list1[i + 3].Text != "λ")
                   while (list1[i + 3].Text != "λ")
                       list1[i++ + 3].Text = "λ";   
        }
    }
}
