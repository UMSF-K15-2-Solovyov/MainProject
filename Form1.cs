using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int SecondDigit(int x) {
            return (x / 10) % 10;
        }
        private void zbtProblem1_1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(ztbA.Text);
            int b = int.Parse(ztbB.Text);
            int c = int.Parse(ztbC.Text);
            int d = SecondDigit(a) + SecondDigit(b) + SecondDigit(c);
            zlaProblem1_1.Text = "Сума других цифр - " + d.ToString();
        }
        static string Row(int n) {
            if (n < 2) return "1";
            return n.ToString() + " " + Row(n - 1);
        }
        private void zbtProblem2_Click(object sender, EventArgs e)
        {
            int n = (int)(zudN.Value);
            zlbTable.Items.Clear();
            for (int i = 1; i <=n; i++)
            {
                zlbTable.Items.Add(Row(i));
            }
        }
    }
}
