using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetVip12.HomeWork.Common;

namespace NetVip12.HomeWork.Interface
{
    public abstract class Gastriloquist
    {
        /// <summary>
        /// 一人
        /// </summary>
        public string Person { get; set; }
        /// <summary>
        /// 一桌
        /// </summary>
        public string Desk { get; set; }
        /// <summary>
        /// 一椅
        /// </summary>
        public string Chair { get; set; }
        /// <summary>
        /// 一扇
        /// </summary>
        public string Fan { get; set; }

        /// <summary>
        /// 一抚尺
        /// </summary>
        public string Ruler { get; set; }

        /// <summary>
        /// 口技开始
        /// </summary>
        public void Start()
        {
            Console.WriteLine("表演开始了");
        }

        /// <summary>
        /// 狗吠
        /// </summary>
        public abstract void DogBark();
        /// <summary>
        /// 人语
        /// </summary>
        public abstract void PersonSpeak();
        /// <summary>
        /// 风声
        /// </summary>
        public abstract void WindSound();

        /// <summary>
        /// 开场白
        /// </summary>
        public virtual void StartSpeech()
        {
            Console.WriteLine("请欣赏口技表演。");
        }

        /// <summary>
        /// 结束语
        /// </summary>
        public virtual void EndSpeech()
        {
            Console.WriteLine("感谢大家的惠顾，欢迎下次再来！");
        }


        protected int burnPoint = 400;

        //protected int temperature;

        public event EventHandler FireStartedHandler;

        public void SetTempearture(int temperature)
        {
            if (temperature >= burnPoint)
            {
                FireStartedHandler.Invoke(this, new FireEventArgs(burnPoint, temperature));
            }
        }








    }




}
