//#define		LOGICAL_TYPES
//#define		CHARACTER_TYPES
//#define		INTEGRAL_TYPES
//#define		DECIMAL_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
#if DECIMAL_TYPES
			Console.WriteLine("FLOAT:\t" + sizeof(float) + "Bytes");
			Console.WriteLine(float.MinValue + "..." + float.MaxValue);


			Console.WriteLine("DOUBLE:\t" + sizeof(double));
			Console.WriteLine(double.MinValue + "..." + double.MaxValue);

			Console.WriteLine("Decimal:\t" + sizeof(decimal) + "Bytes");
#endif




			Console.WriteLine("Введите стоимость тетради:");
			double price_of_copybook = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите количество тетрадей:");
			int number_of_copybook = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите стоимость карандаша:");
			double price_of_pencil = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите количство карадашей:");
			int number_of_pencil = Convert.ToInt32(Console.ReadLine());
			double total_price = price_of_copybook * number_of_copybook * price_of_pencil * number_of_pencil;
			Console.WriteLine("Общая стоимость:" + ((price_of_copybook * number_of_copybook) + (price_of_pencil * number_of_pencil)));


			//Console.WriteLine("Введите стоимость тетради:");
			//double price_of_copybook = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Введите количство комплектов:");
			//double price_of_cover = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Введите количство комплектов: ");
			//int number_of_price = Convert.ToInt32(Console.ReadLine());
			//double total_price = price_of_copybook * price_of_cover * number_of_price;
			//Console.WriteLine("Общая стоимость:" + ((price_of_copybook ) + (price_of_cover * number_of_price)));


			Console.WriteLine("Расстояние до дачи:");
			double distance_to_the_cottage = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Расход бензина:");
			double gasoline_consumption = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Цена литра бензина:");
			int price_of_gasoline = Convert.ToInt32(Console.ReadLine());
			double trip_to_the_cottageand_back = distance_to_the_cottage * gasoline_consumption * price_of_gasoline;
			Console.WriteLine("Общая стоимость:" + trip_to_the_cottageand_back);


			//double a;
			//double b;
			//char oper;
			//double result;
			//Console.WriteLine("Введите первое число:");
			//a = Convert.ToDouble(Console.ReadLine());

			//Console.WriteLine("Введите оператор:");
			//oper = Convert.ToChar(Console.ReadLine());

			//Console.WriteLine("Введите второе число:");
			//b = Convert.ToDouble(Console.ReadLine());

			//if (oper == '+')
			//{
			//	result = a + b;
			//	Console.WriteLine("Сумма чисел равна: " +  result);
			//	Console.ReadKey();
			//}
			//else if(oper == '-')
			//{
			//	result = a - b;
			//	Console.WriteLine("Разность чисел равна: " + result);
			//	Console.ReadKey();
			//}
			//else if (oper == '*')
			//{
			//	result = a * b;
			//	Console.WriteLine("Умножение чисел равна: " + result);
			//	Console.ReadKey();

			//}
			//else if (oper == '/')
			//{
			//	result = a / b;
			//	Console.WriteLine("Деление чисел равна: " + result);
			//	Console.ReadKey();
			//}







		}
	}
}
