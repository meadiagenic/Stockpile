namespace System.Caching
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public static class ICacheExtensions
	{
		public static TResult Fetch<TResult>(this ICache cache, string keyFormat, Func<object[], TResult> callIfMiss, params object[] args)
		{
			var key = string.Format(keyFormat, args);
			return cache.Fetch(key, () => callIfMiss(args));
		}

		public static TResult Fetch<TArg, TResult>(this ICache cache, string keyFormat, Func<TArg, TResult> callIfMiss, TArg arg)
		{
			var key = string.Format(keyFormat, arg);
			return cache.Fetch(key, () => callIfMiss(arg));
		}

		public static TResult Fetch<TArg1, TArg2, TResult>(this ICache cache, string keyFormat, Func<TArg1, TArg2, TResult> callIfMiss, TArg1 arg1, TArg2 arg2)
		{
			var key = string.Format(keyFormat, arg1, arg2);
			return cache.Fetch(keyFormat, () => callIfMiss(arg1, arg2));
		}

		public static TResult Fetch<TArg1, TArg2, TArg3, TResult>(this ICache cache, string keyFormat, Func<TArg1, TArg2, TArg3, TResult> callIfMiss, TArg1 arg1, TArg2 arg2, TArg3 arg3)
		{
			var key = string.Format(keyFormat, arg1, arg2, arg3);
			return cache.Fetch(keyFormat, () => callIfMiss(arg1, arg2, arg3));
		}

		public static TResult Fetch<TArg1, TArg2, TArg3, TArg4, TResult>(this ICache cache, string keyFormat, Func<TArg1, TArg2, TArg3, TArg4, TResult> callIfMiss, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
		{
			var key = string.Format(keyFormat, arg1, arg2, arg3, arg4);
			return cache.Fetch(keyFormat, () => callIfMiss(arg1, arg2, arg3, arg4));
		}

		public static TResult Fetch<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(this ICache cache, string keyFormat, Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> callIfMiss, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
		{
			var key = string.Format(keyFormat, arg1, arg2, arg3, arg4, arg5);
			return cache.Fetch(keyFormat, () => callIfMiss(arg1, arg2, arg3, arg4, arg5));
		}
	}
}
