using System;

namespace HW7
{
    class Doubler
    {
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

        public static int ResSearch(int val)
        {
            int counter = 0;
            while (val > 1)
            {
                if (val % 2 == 0) { counter++; val /= 2; }
                else { counter++; val--; }
            }
            return counter;
        }
    }
}
