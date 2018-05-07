using System;
using System.Collections.Generic;
using System.Text;

namespace LottoGame
{
    class PowerBall
    {
        public static bool PBall(int pb)
        {
            Random rndPb = new Random();
            return rndPb.Next(1, 40) == pb;
        }

    }
}
