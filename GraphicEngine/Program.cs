using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GraphicEngine
{
	class Program
	{
		static void Main(string[] args)
		{
			var shapes = new List<Shape>();

				int 
				//регулирует отступ слева
				d1 = 5,
				d2 = d1+7,	 //12
				d3 = d2+8,   //20
				d4 = d3+3,   //23
				d5 = d4+7,   //30
				//регулирует отступ сверху
				d6 = 5,
				d7 = d6+5;

			// минуты единицы
			shapes.Add(new Zero(d5, d6, ConsoleColor.Yellow));
			shapes.Add(new One(d5, d6, ConsoleColor.Yellow));
			shapes.Add(new Two(d5, d6, ConsoleColor.Yellow));
			shapes.Add(new Three(d5, d6, ConsoleColor.Yellow));
			shapes.Add(new Four(d5, d6, ConsoleColor.Yellow));
			shapes.Add(new Five(d5, d6, ConsoleColor.Yellow));
			shapes.Add(new Six(d5, d6, ConsoleColor.Yellow));
			shapes.Add(new Seven(d5, d6, ConsoleColor.Yellow));
			shapes.Add(new Eight(d5, d6, ConsoleColor.Yellow));
			shapes.Add(new Nine(d5, d6, ConsoleColor.Yellow));

			// минуты десятки
			shapes.Add(new Zero(d4, d6, ConsoleColor.Yellow));
			shapes.Add(new One(d4, d6, ConsoleColor.Yellow));
			shapes.Add(new Two(d4, d6, ConsoleColor.Yellow));
			shapes.Add(new Three(d4, d6, ConsoleColor.Yellow));
			shapes.Add(new Four(d4, d6, ConsoleColor.Yellow));
			shapes.Add(new Five(d4, d6, ConsoleColor.Yellow));

			// часы единицы
			shapes.Add(new Zero(d2, d6, ConsoleColor.Yellow));
			shapes.Add(new One(d2, d6, ConsoleColor.Yellow));
			shapes.Add(new Two(d2, d6, ConsoleColor.Yellow));
			shapes.Add(new Three(d2, d6, ConsoleColor.Yellow));
			shapes.Add(new Four(d2, d6, ConsoleColor.Yellow));
			shapes.Add(new Five(d2, d6, ConsoleColor.Yellow));
			shapes.Add(new Six(d2, d6, ConsoleColor.Yellow));
			shapes.Add(new Seven(d2, d6, ConsoleColor.Yellow));
			shapes.Add(new Eight(d2, d6, ConsoleColor.Yellow));
			shapes.Add(new Nine(d2, d6, ConsoleColor.Yellow));

			// часы десятки
			shapes.Add(new Zero(d1, d6, ConsoleColor.Yellow));
			shapes.Add(new One(d1, d6, ConsoleColor.Yellow));
			shapes.Add(new Two(d1, d6, ConsoleColor.Yellow));

			// установка в черный квадрат
			shapes.Add(new BlackSquer(d1, d6, ConsoleColor.Black));
			shapes.Add(new BlackSquer(d2, d6, ConsoleColor.Black));
			shapes.Add(new BlackSquer(d4, d6, ConsoleColor.Black));
			shapes.Add(new BlackSquer(d5, d6, ConsoleColor.Black));

			// рамочка для часов
			shapes.Add(new Rectangle(3, 3, 34, 9, ConsoleColor.Yellow));
			//бесконечный цикл необходим для работы часов круглосуточно
			for (int d = 0; ; d++)
			{
				shapes[33].Draw(); 
				//Отрисовка - первая цифра
				for (int i = 26; i <= 29; i++)
				{
					shapes[29].Draw();
					shapes[i].Draw();
					//Отрисовка - Вторая цифра
					for (int j = 16; j <= 26; j++)
					{
						shapes[30].Draw();
						shapes[j].Draw();
						//Отрисовка - третья цифра
						for (int n = 10; n <= 15; n++)
						{
							shapes[31].Draw();
							shapes[n].Draw();
							//Отрисовка - четвертая цифра
							for (int m = 0; m <= 9; m++)
							{
								shapes[32].Draw();
								shapes[m].Draw();
								//Отрисовка - секундная точка
								for (int ijnm = 0; ijnm < 1; ijnm++)
								{									
									Engine.SetPixel(d3, d7, ConsoleColor.Yellow);
									Thread.Sleep(500);
									Engine.SetPixel(d3, d7, ConsoleColor.Black);
									Thread.Sleep(500);									
								}								
							}
						}
					}
				}
			}
		}
	}
	static class Engine
	{
		public static void Clean()
		{
			Console.Clear();
		}
		public static void SetPixel(int x, int y, ConsoleColor color = ConsoleColor.White)
		{
			Console.SetCursorPosition(x, y);
			Console.ForegroundColor = color;
			Console.Write("█");
		}
		public static void Draw(List<Shape> shapes)
		{
		}
	}
	abstract class Shape
	{
		public abstract void Draw();

		public int X { get; set; }

		public int Y { get; set; }

		protected Shape(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
	}
	class SquerPixel : Shape 
	{
		public SquerPixel(int x, int y, ConsoleColor color)
			: base(x, y)
		{
			this.Color = color;
		}
		public ConsoleColor Color { get; set; }

		public override void Draw()
		{
			Engine.SetPixel(X, Y, this.Color);
		}
	}
	class Rectangle : SquerPixel
	{
		public Rectangle(int x, int y, int a, int b, ConsoleColor colorline)
				: base(x, y, colorline)
		{
			this.a = a;
			this.b = b;
			this.colorline = colorline;
		}

		public override void Draw()
		{
			for (int i = 0;i <= a; i++)
			{ 
				Engine.SetPixel(X+i, Y, this.colorline);
			}
			for (int i = 0; i <= a; i++)
			{
				Engine.SetPixel(X + i, Y+b, this.colorline);
			}
			for (int i = 0; i <= b; i++)
			{
				Engine.SetPixel(X, Y + i, this.colorline);
			}
			for (int i = 0; i <= b; i++)
			{
				Engine.SetPixel(X + a, Y + i, this.colorline);
			}
		}
		private int a;
		private int b;
		private ConsoleColor colorline;
	}
	class BlackSquer : SquerPixel
	{
		public BlackSquer(int x, int y, ConsoleColor colorline)
				: base(x, y, colorline)
		{
			this.colorline = colorline;
		}

		public override void Draw()
		{
			for (int i = 0; i <= 5; i++)
			{
				for (int j = 0; j <= 5; j++)
				{
					Engine.SetPixel(X + i, Y + j, this.colorline);
				}
			}		
		}
		private ConsoleColor colorline;
	}
}
