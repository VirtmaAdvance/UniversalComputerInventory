namespace UniversalComputerInventory.Services.Extensions.Enumerations
{
	public static class IterableExt
	{
		/// <summary>
		/// Performs the <paramref name="predicate"/> on each item within the enumerable and returns an array of the result from the operation.
		/// </summary>
		/// <typeparam name="TIn"></typeparam>
		/// <typeparam name="TOut"></typeparam>
		/// <param name="source"></param>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public static TOut[] ForEach<TSource, TIn, TOut>(this TSource source, Func<TIn, TOut> predicate) where TSource : IEnumerable<TIn>
		{
			TOut[] res=new TOut[source.Count()];
			int i=0;
			foreach(var sel in source)
				res[i]=predicate(sel);
			return res;
		}

	}
}