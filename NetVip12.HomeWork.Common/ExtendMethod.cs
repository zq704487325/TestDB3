using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetVip12.HomeWork.Common
{
    public static class ExtendMethod
    {
        /// <summary>
        /// 扩展方法从集合中获取随机个对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static List<T> GetRandomObjects<T>(this List<T> source, int nums)
        {

            if (nums > source.Count())
            {
                return source;
            }
            else if (nums <= 0)
            {
                return default(List<T>);
            }
            else
            {
                List<T> list = new List<T>();
                int counts = source.Count();
                List<int> intList = new List<int>();
                for (int i = 0; i<nums; i++)
                {
                    Random rnd = new Random();
                    int num= rnd.Next(counts - 1);
                    if (intList.Contains(num))
                    {
                        i--;
                    }
                    else
                    {
                        intList.Add(num);
                        list.Add(source[num]);
                    }
                }
                return list;

            }

        }
    }
}
