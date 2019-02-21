using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DracoProtos.Core.Extensions
{
    public static class Utils
	{
		public static string FormatHPValue(float value)
		{
			return Utils.FormatHPValue(value, value);
		}

		public static string FormatHPValue(float value, float total)
		{
			float num = value;
			if (total >= 10f)
			{
				if (!num.Equals(0f) && num < 1f)
				{
					num = 1f;
				}
				return Math.Ceiling(num).ToString();
			}
			if (!num.Equals(0f) && (double)num < 0.1)
			{
				num = 0.1f;
			}
			return num.ToString("F1");
		}

		public static int roundPercent(float value)
		{
			return (int)Math.Round((double)(100f * value));
		}

		public static string FormatMetersToKm(float meters)
		{
			return (Math.Floor(meters / 10f) / 100f).ToString();
		}

		public static bool EnumerableEquals<T>(IEnumerable<T> list1, IEnumerable<T> list2)
		{
			if (list1 == null && list2 == null)
			{
				return true;
			}
			if (list1 == null || list2 == null)
			{
				return false;
			}
			Dictionary<T, int> dictionary = new Dictionary<T, int>();
			foreach (T t in list1)
			{
				if (dictionary.ContainsKey(t))
				{
					Dictionary<T, int> dictionary2;
					T key;
					(dictionary2 = dictionary)[key = t] = dictionary2[key] + 1;
				}
				else
				{
					dictionary.Add(t, 1);
				}
			}
			foreach (T t2 in list2)
			{
				if (!dictionary.ContainsKey(t2))
				{
					return false;
				}
				Dictionary<T, int> dictionary2;
				T key2;
				(dictionary2 = dictionary)[key2 = t2] = dictionary2[key2] - 1;
			}
			return dictionary.Values.All((int c) => c == 0);
		}

		public static int EnumerableHashCode<T>(IEnumerable<T> enumerable, int hashCode)
		{
			if (enumerable == null)
			{
				return hashCode;
			}
			foreach (T t in enumerable)
			{
				hashCode = hashCode * 397 + t.GetHashCode();
			}
			return hashCode;
		}

		public static string ToRoman(int number)
		{
			if (number < 0 || number > 3999)
			{
				throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
			}
			if (number < 1)
			{
				return string.Empty;
			}
			if (number >= 1000)
			{
				return "M" + Utils.ToRoman(number - 1000);
			}
			if (number >= 900)
			{
				return "CM" + Utils.ToRoman(number - 900);
			}
			if (number >= 500)
			{
				return "D" + Utils.ToRoman(number - 500);
			}
			if (number >= 400)
			{
				return "CD" + Utils.ToRoman(number - 400);
			}
			if (number >= 100)
			{
				return "C" + Utils.ToRoman(number - 100);
			}
			if (number >= 90)
			{
				return "XC" + Utils.ToRoman(number - 90);
			}
			if (number >= 50)
			{
				return "L" + Utils.ToRoman(number - 50);
			}
			if (number >= 40)
			{
				return "XL" + Utils.ToRoman(number - 40);
			}
			if (number >= 10)
			{
				return "X" + Utils.ToRoman(number - 10);
			}
			if (number >= 9)
			{
				return "IX" + Utils.ToRoman(number - 9);
			}
			if (number >= 5)
			{
				return "V" + Utils.ToRoman(number - 5);
			}
			if (number >= 4)
			{
				return "IV" + Utils.ToRoman(number - 4);
			}
			if (number >= 1)
			{
				return "I" + Utils.ToRoman(number - 1);
			}
			throw new ArgumentOutOfRangeException("something bad happened");
		}

		public static string DictionaryToLogString<TKey, TValue>(IDictionary<TKey, TValue> dic)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (dic != null)
			{
				foreach (KeyValuePair<TKey, TValue> keyValuePair in dic)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append(keyValuePair.Key).Append(":").Append(keyValuePair.Value);
				}
			}
			else
			{
				stringBuilder.Append("null");
			}
			return stringBuilder.ToString();
		}
	}
}
