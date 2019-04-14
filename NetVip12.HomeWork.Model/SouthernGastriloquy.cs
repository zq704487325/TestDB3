using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetVip12.HomeWork.Interface;
using NetVip12.HomeWork.Common;

namespace NetVip12.HomeWork.Model
{
    public class SouthernGastriloquy : Gastriloquist, ICollectFees
    {
        public SouthernGastriloquy()
        {
            this.burnPoint = 800;
        }

        public override void DogBark()
        {
            Console.WriteLine("南派狗叫声");
        }

        public override void PersonSpeak()
        {
            Console.WriteLine("南派哭声声");
        }

        public override void WindSound()
        {

            Console.WriteLine("南派风声");
        }
        /// <summary>
        /// 收费
        /// </summary>
        public void GetCollectFees()
        {
            Console.WriteLine("南派口技收费");
        }

        /// <summary>
        /// 水
        /// </summary>
        public string water;
        /// <summary>
        /// 瓶
        /// </summary>
        public string bottle { get; set; }

        /// <summary>
        /// 模仿大海的声音
        /// </summary>
        public void PlaySeaSound()
        {
            Console.WriteLine("大海的声音！");
        }

        public override void StartSpeech()
        {
            Console.WriteLine("南派口技表演开始");
        }
        /// <summary>
        /// 口技派别
        /// </summary>
        private GastriloquyType gasType = GastriloquyType.South;
        public GastriloquyType GasType
        {
            get { return gasType; }
            private set { gasType = value; }
        }

    }
}
