using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
    class Doubler
    {
        //public int val=0;
        public static int RandVal()
        {
            Random val = new Random();
            return val.Next(0, 100);
        }
        public static int PlusVal(int val) => val + 1;
        public static int MultiVal(int val)=> val *= 2;
        public static bool ResultCheck(int res,int curr)
        {
            if (res == curr) return true;
            else return false;
        }
       
    }
    static class Program
    {       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
