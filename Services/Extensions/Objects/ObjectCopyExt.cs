using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalComputerInventory.Services.Extensions.Objects
{
	public static class ObjectCopyExt
	{

		public static void Copy(this object source, object? target)
		{
			if(source is null)
				throw new ArgumentNullException();
			if(target is null)
				target=Activator.CreateInstance(source.GetType());
			if(source.GetType() != target!.GetType())
				throw new ArgumentException();
			Type type=source.GetType();
			Type targetType=target.GetType();
			foreach(var sel in type.GetFields())
				targetType.GetField(sel.Name)!.SetValue(target, sel.GetValue(source));
		}

	}
}
