using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetVip12.HomeWork.Common;

namespace NetVip12.HomeWork.Model
{
    public class EasternAudience
    {
        public static void HasbandCry(object sender, EventArgs e)
        {
            EasternGastriloquy wesGas2 = (EasternGastriloquy)sender;
            FireEventArgs fe = (FireEventArgs)e;
            Console.WriteLine($"派别：{wesGas2.GasType.ToString()}；燃点：{fe.BurnPoint}；当前温度：{fe.NowTemp}");
            Console.WriteLine("夫起大呼");
        }

        public static void WifeCry(object sender, EventArgs e)
        {
            Console.WriteLine("妇亦起大呼");

        }

        public static void TwoSonCry(object sender, EventArgs e)
        {
            Console.WriteLine("两儿齐哭");
        }

        public static void ManyManCry(object sender, EventArgs e)
        {
            Console.WriteLine("俄而百千人大呼");
        }

        public static void ManySonCry(object sender, EventArgs e)
        {
            Console.WriteLine("百千儿哭");
        }
        public static void ManyDogBark(object sender, EventArgs e)
        {
            Console.WriteLine("百千犬吠");
        }
    }
}
