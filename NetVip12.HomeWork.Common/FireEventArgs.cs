using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetVip12.HomeWork.Common
{
    public class FireEventArgs:EventArgs
    {
        public FireEventArgs(int burnPoint,int nowTemp)
        {
            this.BurnPoint = burnPoint;
            this.NowTemp = nowTemp;
            
        }
        public int BurnPoint { get;private set; }
        public int NowTemp { get;private set; }

    }
}
