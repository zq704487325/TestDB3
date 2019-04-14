using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetVip12.HomeWork.Interface;
using NetVip12.HomeWork.Model;
using NetVip12.HomeWork.Common;
using NetVip12.HomeWork.BLL;



namespace NetVip12HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {


            #region 第三次作业 作业2

            //Console.WriteLine("****************声明一个东派的值****************");

            //EasternGastriloquy eastGtri = new EasternGastriloquy();
            //eastGtri.Bowl = "碗";
            //eastGtri.Chair = "椅子";
            //eastGtri.Desk = "zhuozi";
            //eastGtri.Fan = "扇子";
            //eastGtri.Person = "东派口技师";
            //eastGtri.Ruler = "抚尺";
            //eastGtri.chopsticks = "筷子";
            //ReflectionExtend.GetProAndFieldName(eastGtri);

            #endregion


            #region 第三次作业 作业3
            {
                //EasternGastriloquy easGas = new EasternGastriloquy();
                //NorthernGastriloquy norGas = new NorthernGastriloquy();
                //SouthernGastriloquy souGas = new SouthernGastriloquy();
                //WesternGastriloquy wesGas = new WesternGastriloquy();
                //PlayUniTech(easGas.PlayTigerRoar);
                //PlayUniTech(norGas.PlayPrairieSound);
                //PlayUniTech(souGas.PlaySeaSound);
                //PlayUniTech(wesGas.PlayMouseSound);

            }


            #endregion


            #region  第三次作业 作业4
            //SouthernGastriloquy souGas = new SouthernGastriloquy();

            //souGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("夫起大呼"); };
            //souGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("妇亦起大呼"); };
            //souGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("两儿齐哭"); };
            //souGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("俄而百千人大呼"); };
            //souGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("百千儿哭"); };
            //souGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("百千犬吠"); };

            //souGas.SetTempearture(1000);

            //NorthernGastriloquy norGas = new NorthernGastriloquy();
            //norGas.FireStartedHandler += NorthernAudience.HasbandCry;
            //norGas.FireStartedHandler += NorthernAudience.WifeCry;
            //norGas.FireStartedHandler += NorthernAudience.TwoSonCry;
            //norGas.FireStartedHandler += NorthernAudience.ManyManCry;
            //norGas.FireStartedHandler += NorthernAudience.ManySonCry;
            //norGas.FireStartedHandler += NorthernAudience.ManyDogBark;
            //norGas.SetTempearture(900);

            //WesternGastriloquy wesGas = new WesternGastriloquy();

            //wesGas.FireStartedHandler += (object sender, EventArgs e) =>
            //{
            //    WesternGastriloquy wesGas2 = (WesternGastriloquy)sender;
            //    FireEventArgs fe = (FireEventArgs)e;
            //    Console.WriteLine($"派别：{wesGas2.GasType.ToString()}；燃点：{fe.BurnPoint}；当前温度：{fe.NowTemp}");
            //    Console.WriteLine("夫起大呼");
            //};
            //wesGas.FireStartedHandler += (object sender, EventArgs e) =>
            //{
            //    Console.WriteLine("妇亦起大呼");
            //};
            //wesGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("两儿齐哭"); };
            //wesGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("俄而百千人大呼"); };
            //wesGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("百千儿哭"); };
            //wesGas.FireStartedHandler += (object sender, EventArgs e) => { Console.WriteLine("百千犬吠"); };
            //wesGas.SetTempearture(500);


            //EasternGastriloquy easGas = new EasternGastriloquy();
            //easGas.FireStartedHandler += EasternAudience.HasbandCry;
            //easGas.FireStartedHandler += EasternAudience.WifeCry;
            //easGas.FireStartedHandler += EasternAudience.TwoSonCry;
            //easGas.FireStartedHandler += EasternAudience.ManyManCry;
            //easGas.FireStartedHandler += EasternAudience.ManySonCry;
            //easGas.FireStartedHandler += EasternAudience.ManyDogBark;
            //easGas.SetTempearture(2000);

            #endregion


            #region 第三次作业 作业5

            //MiddleGastriloquy midGas = new MiddleGastriloquy();
            //midGas.PlayHighHandler += (sender, e) => { Console.WriteLine("Hight"); };
            //Show(midGas);

            #endregion

            #region 第三次作业 作业6
            //List<int> list = new List<int>() { 1, 5, 9, 8, 6, 4, 7, 3, 2 };
            //List<int> newList = list.GetRandomObjects(3);
            //foreach (var i in newList)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion 


            Console.ReadKey();

        }


        private static void PlayUniTech(Action action)
        {
            Console.WriteLine("绝活马上开始了！");
            action.Invoke();
            Console.WriteLine("绝活表演结束，大家鼓掌！");
        }


        public static void Show(MiddleGastriloquy midGas)
        {
            midGas.Start();
            midGas.StartSpeech();
            midGas.PlayStartEvent();
            midGas.DogBark();
            midGas.PersonSpeak();
            midGas.WindSound();
            midGas.PlayThunder();
            midGas.PlayHightEvent();
            midGas.EndSpeech();
            midGas.GetCollectFees();
            midGas.PlayFinishEvent();
        }
    }
}
