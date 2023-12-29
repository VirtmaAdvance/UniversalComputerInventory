using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UniversalComputerInventory.Services.Types
{
    public struct VMemberInfo
    {

        public readonly Type MemberType;
        public FieldInfo[] Fields => MemberType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        public FieldInfo[] SetableFields => MemberType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetField | BindingFlags.SetProperty);





        public VMemberInfo(Type type)
        {
            MemberType=type;
        }


    }
}
