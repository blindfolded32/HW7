using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.

Студент: Чирков В.А.
Группа: GU_games_1235
 */

namespace HW7
{
    
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int val = 1, counter = 0, Nval;
        Stack<int> ActStack = new Stack<int>();
        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Hide();
            PlusBtn.Show();
            MultiBtn.Show();
            CounterLbl.Show();
            ValLbl.Show();
            NeedLbl.Show();
            Nval = Doubler.RandVal();
            NeedLbl.Text = $"Need to get: {Nval}";
            CancelBtn.Show();
            CompActLbl.Show();
            RestartBtn.Show();
            CompActLbl.Text = $"Computer Actions count: {Doubler.ResSearch(Nval)}";
            
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            ActStack.Push(val);
            val = Doubler.PlusVal(val);
            ValLbl.Text = $"Current value is {val}";
            CounterLbl.Text = $"Actions count {counter++} ";
            if (Doubler.ResultCheck(Nval, val)) MessageBox.Show($"YOU DID IT!!!!\n Actions count {counter}");
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try again");
            val = 1;
            counter = 0;
            ValLbl.Text = $"Current value is {val}";
            CounterLbl.Text = $"Actions count {counter} ";
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            ActStack.Push(val);
            val = Doubler.MultiVal(val);
            ValLbl.Text = $"Current value is {val}";
            CounterLbl.Text = $"Actions count {counter++}";
            if (Doubler.ResultCheck(Nval, val)) MessageBox.Show($"YOU DID IT!!!!\n Actions count {counter}");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            val = ActStack.Pop();
            ValLbl.Text = $"Current value is {val}";
            CounterLbl.Text = $"Actions count {counter--}";
        }
    }
}
