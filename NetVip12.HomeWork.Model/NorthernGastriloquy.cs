using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetVip12.HomeWork.Interface;
using NetVip12.HomeWork.Common;


namespace NetVip12.HomeWork.Model
{
    public class NorthernGastriloquy : Gastriloquist, ICollectFees
    {

        public NorthernGastriloquy()
        {
            this.burnPoint = 1000;
        }

        public override void DogBark()
        {
            Console.WriteLine("北派狗叫声");
        }

        public override void PersonSpeak()
        {
            Console.WriteLine("北派哭声声");
        }

        public override void WindSound()
        {

            Console.WriteLine("北派风声");
        }
        /// <summary>
        /// 收费
        /// </summary>
        public void GetCollectFees()
        {
            Console.WriteLine("北派口技收费");
        }


        /// <summary>
        /// 绳子
        /// </summary>
        public string rope;
        /// <summary>
        /// 棉花
        /// </summary>
        public string Cotton { get; set; }
        /// <summary>
        /// 模仿草原的声音
        /// </summary>
        public void PlayPrairieSound()
        {
            Console.WriteLine("草原的声音");
        }

        /// <summary>
        /// 结束语
        /// </summary>
        public override void EndSpeech()
        {
            Console.WriteLine("北派口技表演结束！");
        }

     

        /// <summary>
        /// 口技派别
        /// </summary>
        private GastriloquyType gasType = GastriloquyType.North;
        public GastriloquyType GasType
        {
            get { return gasType; }
            private set { gasType = value; }
        }


    }
}
