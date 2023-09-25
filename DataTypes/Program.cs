//#define		LOGICAL_TYPES
//#define		CHARACTER_TYPES
//#define		INTEGRAL_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimiter = "\n-------------------------------------\n";
		static void Main(string[] args)
		{
#if LOGICAL_TYPES


			Console.WriteLine("BOOL:");
			Console.WriteLine(sizeof(bool));
			Console.WriteLine(true.GetType());
			Console.WriteLine((3 + 2.5).GetType());
#endif
#if CHARACTER_TYPES

			Console.WriteLine("CHAR:");
			Console.WriteLine(sizeof(char));
			Console.WriteLine((int)(char.MinValue));
			Console.WriteLine((int)(char.MaxValue));
#endif
#if CHARACTER_TYPES

			Console.WriteLine("SHORT");
			Console.WriteLine(sizeof(short));
			Console.WriteLine("USHORT:\t" + ushort.MinValue + " " + ushort.MaxValue);
			Console.WriteLine("SHORT:\t" + ushort.MaxValue + " " + ushort.MinValue);
			Console.WriteLine(delimiter);
#endif
#if INTEGRAL_TYPES
			Console.WriteLine("INT");
			Console.WriteLine(sizeof(int));
			Console.WriteLine("UINT\t" + int.MinValue + "..." + uint.MaxValue);
			Console.WriteLine("INT\t" + int.MaxValue + "..." + uint.MinValue);
		
			Console.WriteLine("LONG");
			Console.WriteLine(sizeof(long));
			Console.WriteLine("ULONG\t" + ulong.MinValue + "..." + ulong.MaxValue);
			Console.WriteLine("ULONG\t" + ulong.MaxValue + "..." + ulong.MinValue);
#endif

			Console.WriteLine("FLOAT:\t" + sizeof(float) + "Bytes");
			Console.WriteLine(float.MinValue + "..." + float.MaxValue);


			Console.WriteLine("DOUBLE:\t" + sizeof(double));
			Console.WriteLine(double.MinValue + "..." + double.MaxValue);

			Console.WriteLine("Decimal:\t" + sizeof(decimal) + "Bytes");

		}
	}
}
