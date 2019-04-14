using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetVip12.HomeWork.Interface;
using NetVip12.HomeWork.Common;

namespace NetVip12.HomeWork.Model
{
    public class WesternGastriloquy : Gastriloquist, ICollectFees
    {
        

        public override void DogBark()
        {
            Console.WriteLine("西派狗叫声");
        }

        public override void PersonSpeak()
        {
            Console.WriteLine("西派哭声声");
        }

        public override void WindSound()
        {

            Console.WriteLine("西派风声");
        }
        /// <summary>
        /// 收费
        /// </summary>
        public void GetCollectFees()
        {
            Console.WriteLine("西派口技收费");
        }
        /// <summary>
        /// 刀
        /// </summary>
        public string knife;
        /// <summary>
        /// 盘
        /// </summary>
        public string Plate { get; set; }

        /// <summary>
        /// 模仿老鼠叫声
        /// </summary>
        public void PlayMouseSound()
        {
            Console.WriteLine("老鼠的吱吱声");
        }

        public override void StartSpeech()
        {
            Console.WriteLine("西派口技表演开始！");
        }
        public override void EndSpeech()
        {
            Console.WriteLine("西派口技表演结束！");
        }

        /// <summary>
        /// 口技派别
        /// </summary>
        private GastriloquyType gasType = GastriloquyType.West;
        public GastriloquyType GasType
        {
            get { return gasType; }
            private set { gasType = value; }
        }
    }
}
