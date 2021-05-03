using System;

namespace NugetTest
{
	public static class ObjectExtensions
	{
		public static bool TryGetTypeFromString(this string obj, out Type type)
		{
			bool result = false;
			type = null;
			if (int.TryParse(obj, out _))
			{
				result = true;
				type = typeof(int);
			}
			else if (decimal.TryParse(obj, out _))
			{
				result = true;
				type = typeof(decimal);
			}
			else if (double.TryParse(obj, out _))
			{
				result = true;
				type = typeof(double);
			}
			else if (bool.TryParse(obj, out _))
			{
				result = true;
				type = typeof(bool);
			}
			return result;
		}
	}
}
