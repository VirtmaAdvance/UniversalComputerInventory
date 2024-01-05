using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalComputerInventory.Services.Extensions.Enumerations
{
	public static class IterableMathExt
	{

		public static double IterateMathDouble<TIn>(this IEnumerable<TIn> enumerable, Func<TIn, double, double> predicate)
		{
			double res=0;
			foreach(var sel in enumerable)
				res=predicate(sel, res);
			return res;
		}

	}
}
