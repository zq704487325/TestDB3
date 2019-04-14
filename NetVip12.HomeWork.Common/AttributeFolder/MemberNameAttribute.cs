using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetVip12.HomeWork.Common.AttributeFolder
{
    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Property,AllowMultiple = false,Inherited =true)]
    public class MemberNameAttribute:Attribute
    {
        public string Name { get; private set; }

        public MemberNameAttribute(string name)
        {
            this.Name = name;
        }
    }
}
