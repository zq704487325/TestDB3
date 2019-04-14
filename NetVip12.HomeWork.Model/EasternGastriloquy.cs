using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetVip12.HomeWork.Interface;
using NetVip12.HomeWork.Common;

namespace NetVip12.HomeWork.Model
{
    public class EasternGastriloquy : Gastriloquist, ICollectFees
    {
        public override void DogBark()
        {
            Console.WriteLine("东派狗叫声");
        }

        public override void PersonSpeak()
        {
            Console.WriteLine("东派哭声声");
        }

        public override void WindSound()
        {

            Console.WriteLine("东派风声");
        }
        /// <summary>
        /// 收费
        /// </summary>
        public void GetCollectFees()
        {
            Console.WriteLine("东派口技收费");
        }

        /// <summary>
        /// 筷子
        /// </summary>
        public string chopsticks;
       /// <summary>
       /// 碗
       /// </summary>
        public string Bowl { get; set; }

        /// <summary>
        /// 老虎吼声
        /// </summary>
        public void PlayTigerRoar()
        {
            Console.WriteLine("老虎的吼声！");
        }




        /// <summary>
        /// 口技派别
        /// </summary>
        private GastriloquyType gasType = GastriloquyType.East;
        public GastriloquyType GasType
        {
            get { return gasType; }
            private set { gasType = value; }
        }



    }
}
