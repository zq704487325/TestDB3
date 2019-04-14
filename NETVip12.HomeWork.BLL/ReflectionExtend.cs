using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetVip12.HomeWork.Common;
using NetVip12.HomeWork.Interface;


namespace NetVip12.HomeWork.BLL
{
    public  class ReflectionExtend
    {

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void GetProAndFieldName<T>(T t) where T:Gastriloquist,ICollectFees
        {
            ReflectionHelp.GetFieldNameValue(t);
            ReflectionHelp.GetProNameValue(t);
            Gastriloquist gas = (Gastriloquist)t;
            gas.Start();
            gas.StartSpeech();
            gas.DogBark();
            gas.PersonSpeak();
            gas.WindSound();
            gas.EndSpeech();
            ((ICollectFees)t).GetCollectFees();
           

        }

    }
}
