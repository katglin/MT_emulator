using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace mt_emulyator
{
    static class Program
    {
        public static Form1 MyForm1 = null;
        public static int M = 10;
        public static bool stop = false;
        public static bool pause = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyForm1 = new Form1();
            Application.Run(MyForm1);
        }

        public static void rec(int n, int i, char[] s)
        {
            string w = "";
            if (i == n)
            {
                for (int j = 0; j < n; j++)
                    w = w + s[j];
                MyForm1.listBox1.Items.Add(w);
                return;
            }
            s[i] = '0';
            rec(n, i + 1, s);
            s[i] = '1';
            rec(n, i + 1, s);
        }

        public static int check(int pr)
        {
            char qt, a1t, a2t;
            int i = 0;
            char v1 = 'R', v2 = 'E';
            int p = 0, k1 = 3, k2 = 3;
            int iter = 0;
            string s1 = "", s2 = "";
            qt = '0';
            a1t = Convert.ToChar(MyForm1.list1[3].Text);
            a2t = Convert.ToChar(MyForm1.list2[3].Text);
            stop = false;
            if (pr == 1)
            {
                i = 3;
                while (MyForm1.list1[i].Text != "λ")
                    s1 = s1 + MyForm1.list1[i++].Text;
                MyForm1.listBox3.Items.Add("_q0_" + s1);
                MyForm1.listBox3.Items.Add("_q0_");
                MyForm1.listBox3.Items.Add("");
            }
            while (qt != 'z' && !stop)
            {
                Application.DoEvents();
                if (stop) break;
                else if (pause)
                {
                    MyForm1.status.Text = "Работа приостановлена...";
                    while (pause)
                        Application.DoEvents();
                    MyForm1.status.Text = "Программа работает...";
                }
                iter++;
                while (Convert.ToChar(MyForm1.mtTable.Rows[p].Cells[0].Value) != qt) p++;
                while (a1t != Convert.ToChar(MyForm1.mtTable.Rows[p].Cells[1].Value)) p++;
                while (a2t != Convert.ToChar(MyForm1.mtTable.Rows[p].Cells[2].Value)) p++;
                if (pr == 1)
                {
                    MyForm1.list1[k1].BackColor = Color.Cyan;
                    MyForm1.list2[k2].BackColor = Color.Cyan;
                    MyForm1.lent1.Refresh();
                    MyForm1.lent2.Refresh();
                }
                MyForm1.list1[k1].Text = MyForm1.mtTable.Rows[p].Cells[4].Value.ToString();
                MyForm1.list2[k2].Text = MyForm1.mtTable.Rows[p].Cells[5].Value.ToString();
                qt = Convert.ToChar(MyForm1.mtTable.Rows[p].Cells[3].Value);
                v1 = Convert.ToChar(MyForm1.mtTable.Rows[p].Cells[6].Value);
                v2 = Convert.ToChar(MyForm1.mtTable.Rows[p].Cells[7].Value);
                MyForm1.list1[k1].BackColor = Color.WhiteSmoke;
                MyForm1.list2[k2].BackColor = Color.WhiteSmoke;
                if (v1 == 'R') k1++;
                else if (v1 == 'L') k1--;
                if (v2 == 'R') k2++;
                else if (v2 == 'L') k2--;
                if (pr == 1)
                {
                    MyForm1.CountSteps.Text = "Выполнено шагов: " + (iter).ToString();
                    s1 = "";
                    s2 = "";
                    for (i = 0; i < k1; i++)
                        if (MyForm1.list1[i].Text != "λ")
                            s1 = s1 + MyForm1.list1[i].Text;
                    s1 = s1 + "_q" + qt + "_";
                    for (i = 0; i < k2; i++)
                        if (MyForm1.list2[i].Text != "λ")
                            s2 = s2 + MyForm1.list2[i].Text;
                    s2 = s2 + "_q" + qt + "_"; 
                    MyForm1.mtTable.Rows[p].DefaultCellStyle.BackColor = Color.Red;
                    MyForm1.mtTable.Refresh();
                    Thread.Sleep(800 - 200 * MyForm1.sw.Value);
                    MyForm1.mtTable.Rows[p].DefaultCellStyle.BackColor = Color.White;
                    i = k1;
                    while (MyForm1.list1[i].Text != "λ")
                        s1 = s1 + MyForm1.list1[i++].Text;
                    i = k2;
                    while (MyForm1.list2[i].Text != "λ")
                        s2 = s2 + MyForm1.list2[i++].Text;
                    MyForm1.listBox3.Items.Add(s1);
                    MyForm1.listBox3.Items.Add(s2);
                    MyForm1.listBox3.Items.Add("");
                    MyForm1.listBox3.Refresh();
                }
                a1t = Convert.ToChar(MyForm1.list1[k1].Text);
                a2t = Convert.ToChar(MyForm1.list2[k2].Text);
                p = 0;
            }
            if (pr == 1)
            {
                if (stop) MyForm1.status.Text = "Работа была прервана";
                else if (MyForm1.list1[k1].Text == "1") MyForm1.status.Text = "Слово принадлежит языку";
                else MyForm1.status.Text = "Слово не принадлежит языку";
            }    
                return iter; 
        }
    }
}
