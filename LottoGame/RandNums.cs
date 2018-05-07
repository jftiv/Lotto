using System;
using System.Collections.Generic;
using System.Text;


namespace LottoGame
{
    public class RandNums
    {
        public int[] WinNums()
        {
            Random rndNum = new Random();
            int[] winNum = new int[6];
            for (int i = 0; i < 6; i++)
            {
                winNum[i] = rndNum.Next(1, 40);
                Console.Write("{0} ", winNum[i]);
            }
            return winNum;
        }
    }
}
