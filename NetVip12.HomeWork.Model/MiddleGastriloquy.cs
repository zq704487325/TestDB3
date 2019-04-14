using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetVip12.HomeWork.Interface;

namespace NetVip12.HomeWork.Model
{
    public class MiddleGastriloquy: Gastriloquist,ICollectFees
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
        /// 木棍
        /// </summary>
        public string crabstick;
        /// <summary>
        /// 罐子
        /// </summary>
        public string Jar { get; set; }

        /// <summary>
        /// 打雷的声音
        /// </summary>
        public void PlayThunder()
        {
            Console.WriteLine("打雷的声音！");
        }


        public event EventHandler PlayStartHandler;
        public event EventHandler PlayHighHandler;
        public event EventHandler PlayFinishHandler;
        /// <summary>
        /// 触发开始事件
        /// </summary>
        public  void PlayStartEvent()
        {
            PlayStartHandler?.Invoke(this,default(EventArgs));
        }

        /// <summary>
        /// 触发高潮事件
        /// </summary>
        public  void PlayHightEvent()
        {
            PlayHighHandler?.Invoke(this, default(EventArgs));
        }


        /// <summary>
        /// 触发结束事件
        /// </summary>
        public void PlayFinishEvent()
        {
            PlayFinishHandler?.Invoke(this, default(EventArgs));
        }

        


    }
}
