using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NetVip12.HomeWork.Common.AttributeFolder;

namespace NetVip12.HomeWork.Common
{
    public class ReflectionHelp
    {
        /// <summary>
        /// 给字段添加描述名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void GetFieldNameValue<T>(T t)
        {
            Type type = t.GetType();
            Console.WriteLine("****************字段***************");
            foreach (var field in type.GetFields())
            {

                if (field.IsDefined(typeof(MemberNameAttribute), true))
                {
                    object o = field.GetCustomAttribute(typeof(MemberNameAttribute), true);
                    MemberNameAttribute memberName = (MemberNameAttribute)o;
                    Console.WriteLine($"{memberName.Name}:" + field.GetValue(t));
                }
                else
                {
                    Console.WriteLine($"{field.Name}:" + field.GetValue(t));
                }

            }


        }

        /// <summary>
        /// 给属性添加描述名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void GetProNameValue<T>(T t)
        {
            Type type = t.GetType();
            Console.WriteLine("****************属性***************");
            foreach (var pro in type.GetProperties())
            {
                if (pro.IsDefined(typeof(MemberNameAttribute), true))
                {
                    object o = pro.GetCustomAttribute(typeof(MemberNameAttribute), true);
                    MemberNameAttribute memberName = (MemberNameAttribute)o;
                    Console.WriteLine($"{memberName.Name}:" + pro.GetValue(t));
                }
                else
                {
                    Console.WriteLine($"{pro.Name}:" + pro.GetValue(t));
                }

            }

        }
    }



}
