using System;

namespace task2
{

    static class GuessNumber
    {
        public static int INval;        

        static public int RandomGen()
        {
            Random r = new Random();
            return r.Next(0, 100);
        }
    }
}
