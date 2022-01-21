using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sum_all_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumEvery_Click(object sender, EventArgs e)
        {
            int endNumber = int.Parse(txtBoxNum.Text);
            int i = 1, sum = 0;

            while (i <= endNumber)
            {
                sum += i;
                i += 1;
            }

            MessageBox.Show(sum.ToString());
        }

        private void btnSumEven_Click(object sender, EventArgs e)
        {
            int endNumber = int.Parse(txtBoxNum.Text);
            int i = 2, sum = 0;

            while (i <= endNumber)
            {
                sum += i;
                i += 2;
            }

            MessageBox.Show(sum.ToString());
        }
    }
}
