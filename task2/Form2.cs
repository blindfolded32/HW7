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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void ChkBtn_Click(object sender, EventArgs e)
        {
            GuessNumber.INval = Convert.ToInt32(NumBox.Text);
            Dispose();
        }
    }
}
