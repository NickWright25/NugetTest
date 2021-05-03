using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetTest
{
	public static class ObjectExtensions
	{
		public static Type TryGetTypeFromString(this string obj)
		{
			if (int.TryParse(obj, out _))
			{
				return typeof(int);
			}
			else if (decimal.TryParse(obj, out _))
			{
				return typeof(decimal);
			}
			else if (double.TryParse(obj, out _))
			{
				return typeof(double);
			}
			else if (bool.TryParse(obj, out _))
			{
				return typeof(bool);
			}
			else
			{
				return null;
			}
		}
	}
}
