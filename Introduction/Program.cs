//#define CONSOLE_SETTINGS
//#define CONSOLE_SHOOTER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Introduction
{
    class Program
    {
        const string delimiter = "\n-----------------------------------\n";
        static void Main(string[] args)
        {

#if CONSOLE_SETTINGS
			//Console.WindowLeft = 10;
			//Console.WindowTop = 10;
			//Console.SetWindowPosition(10, 10);
			Console.Title = "Introduction to .NET";

			Console.Beep(37, 500);

			//int start_x = 10;
			//int start_y = 10;
			int width = 120;
			int height = 32;

			Console.SetBufferSize(width, height);
			Console.SetWindowSize(width, height);

			Console.WriteLine("Buffer width:\t" + Console.BufferWidth);
			Console.WriteLine("Buffer height\t" + Console.BufferHeight);
			Console.WriteLine(delimiter);
			Console.WriteLine("Window width:\t" + Console.WindowWidth);
			Console.WriteLine("Window height:\t" + Console.WindowHeight);

			Console.Write("Hello .NET");
			Console.WriteLine();

			//Console.SetCursorPosition(20, 10);
			Console.CursorLeft = 50;
			Console.CursorTop = 8;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine("Cursor position check");

			Console.SetCursorPosition(25, 7);
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Cursor position check2");
			Console.BackgroundColor = ConsoleColor.Black;

			//Console.SetCursorPosition(0, 0);
			Console.Write("Finita la comedia");
			Console.ResetColor(); 
#endif

			//Console.Write("Введите Ваше имя: ");
			//string first_name = Console.ReadLine();

			//Console.Write("Введите Вашу фамилию: ");
			//string last_name = Console.ReadLine();

			//Console.Write("Введите Ваш возраст: ");
			//int age = Convert.ToInt32(Console.ReadLine());

			//1) Конкатенация строк:
			//Console.WriteLine("Имя: " + first_name + ", фамилия: " + last_name + ", возраст: " + age + " лет.");

			//2) Форматирование строк:
			//Console.WriteLine(string.Format("Имя: {0}, фамилия: {1}, возраст: {2} лет.", first_name, last_name, age));

			//3) Интерполяция строк:
			//Console.WriteLine($"Имя: {{{first_name}}}, фамилия: {last_name}, возраст: {age} лет.");

#if CONSOLE_SHOOTER
			ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.W: Console.WriteLine("Вперед"); break;
                    case ConsoleKey.S: Console.WriteLine("Назад"); break;
                    case ConsoleKey.D: Console.WriteLine("Влево"); break;
                    case ConsoleKey.A: Console.WriteLine("Вправо"); break;
                    case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
                    default:
                        Console.WriteLine("Error"); break;
                }
            } while (Convert.ToChar(key) != 27);
#endif
			
			int n;
			Console.WriteLine("Введите размер фигуры: ");
			n = Convert.ToInt32(Console.ReadLine());		
			Console.WriteLine();
			//0
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}		
			//1
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}

			//2			
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			//3
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("  ");
				}
				for (int j = i; j < n; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			//4
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < (n - 1); j++)
				{
					Console.Write("  ");
				}
				for (int j = 0; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			//5
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++) Console.Write(" "); Console.Write("/");
				for (int j = 0; j < i; j++) Console.Write("  "); Console.Write("\\");
				Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");
				for (int j = i; j < n - 1; j++) Console.Write("  "); Console.Write("/");
				Console.WriteLine();
			}

			//6
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if ((i + j) % 2 == 0)
					{
						Console.Write("+ ");
					}
					else
					{
						Console.Write("- ");

					}
				}
				Console.WriteLine();
			}




			}

	}
}












//4
//int n = 7;


//5
//int n = 7;


//6
//int n = 7;





//for (int i = 0; i <= n; i++)
//{
//    for (int j = n; j > i; j--)
//    {
//        Console.Write("  ");
//    }
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write("*");
//    } for (int k = 0; k <= i; k++)
//    {
//        Console.Write("*");
//    }for (int d = 0; d <= i; d++)
//    {
//        Console.Write("*");
//    }for (int s = 0; s <= i; s++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}