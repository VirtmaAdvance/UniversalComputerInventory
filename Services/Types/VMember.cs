using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UniversalComputerInventory.Services.Extensions.Enums;

namespace UniversalComputerInventory.Services.Types
{
    public struct VMember
    {

        public readonly Type MemberType;
        public readonly FieldInfo[] Fields => MemberType.GetFields(EnumExt.GetBaseValues(BindingFlags));


        public VMember(Type type)
        {
            MemberType=type;
        }


    }
}
