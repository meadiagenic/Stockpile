using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace System.Caching
{
	internal static class OptionsExtensions
	{
		private static IDictionary<Type, IEnumerable<PropertyDescriptor>> _propCache = new Dictionary<Type, IEnumerable<PropertyDescriptor>>();
		internal static IEnumerable<PropertyDescriptor> GetPropertiesFromCache(this Type type)
		{
			IEnumerable<PropertyDescriptor> props;
			if (!_propCache.TryGetValue(type, out props))
			{
				props = TypeDescriptor.GetProperties(type).Cast<PropertyDescriptor>();
				_propCache.Add(type, props);
			}
			return props;
		}

		internal static dynamic AsDynamic<T>(this T @object)
		{
			var objectType = (@object != null) ? @object.GetType() : typeof(T);
			var result = new ExpandoObject();
			var d = result as IDictionary<string, object>;
			if (objectType == typeof(ExpandoObject)) return @object;

			var props = objectType.GetPropertiesFromCache();
			if (@object == null) return result;
			foreach (var prop in props)
			{
				d.Add(prop.Name, prop.GetValue(@object));
			}
			return result;
		}

		internal static IDictionary<string, object> AsDictionary<T>(this T @object)
		{
			return (IDictionary<string, object>)@object.AsDynamic();
		}

		internal class EmptyDictionary<TKey, TValue> : Dictionary<TKey, TValue>
		{
			public EmptyDictionary(IEqualityComparer<TKey> comparer)
				: base(comparer)
			{

			}

			public new TValue this[TKey key]
			{
				get { if (base.ContainsKey(key)) { return base[key]; } else { return default(TValue); } }
				set
				{
					base[key] = value;
				}
			}
		}

		public static bool AsBoolean(this object value)
		{
			if (value == null) return false;
			if (value is bool) return (bool)value;

			var valueString = value as string;
			if (!string.IsNullOrEmpty(valueString))
			{
				if (valueString.ToLowerInvariant() == "true") return true;
				if (valueString.ToLowerInvariant() == "false") return false;
			}

			var valueint = value as int?;
			if (valueint != null && valueint.HasValue)
			{
				if (valueint.Value == 0) return false;
				else return true;
			}
			return false;
		}
	}
}
