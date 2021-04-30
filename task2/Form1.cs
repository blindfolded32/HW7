using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
         int val,count=0;       
        public Form1()
        {
            InitializeComponent();
        }
     
        private void InputBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2.Close();
            if (GuessNumber.INval == val) { MessageBox.Show($"HOORAY in {count} tries");}
            if (GuessNumber.INval > val) { MessageBox.Show("Try lesser"); count++; CounterLbl.Text= $"Actions count: {count}"; MLLbl.Text = $"Надо меньше {GuessNumber.INval}"; }
            if (GuessNumber.INval < val) { MessageBox.Show("Try greater"); count++; CounterLbl.Text = $"Actions count: {count}"; MLLbl.Text = $"Надо больше {GuessNumber.INval}"; }

        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Hide();
            InputBtn.Show();
            MLLbl.Show();
            CounterLbl.Show();
           val= GuessNumber.RandomGen();
            
        }
    }
}
