using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEngine
{
	class Numerics:Shape
	{
		public ConsoleColor	Color { get; set;}
		public Numerics(int x, int y, ConsoleColor color)
			: base(x, y)
		{
			this.Color = color;
		}
		public override void Draw()
		{
			Engine.SetPixel(X, Y, this.Color);
		}
	}
	class Zero:Numerics
	{
		public ConsoleColor colorline { get; set; }
		public Zero (int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y, this.colorline);
			}
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 5, this.colorline);
			}
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X, Y + i, this.colorline);
			}
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + 5, Y + i, this.colorline);
			}
		}
	}
	class One : Numerics
	{
		public ConsoleColor colorline { get; set; }
		public One(int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			//Диагональ
			for (int i = 0; i <= 2; i++)
			{
				Engine.SetPixel((X - i) + 2, Y + i, this.colorline);

			}
			//Вертикальная линия
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + 3, Y + i, this.colorline);
			}
			//Нижняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y+5, this.colorline);
			}		
		}
	}
	class Two : Numerics
	{
		public ConsoleColor colorline { get; set; }
		public Two(int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			//Верхняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 2; i++)
			{
				Engine.SetPixel(X + 5, Y + i, this.colorline);
			}
			//Средняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 3, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 2; i++)
			{
				Engine.SetPixel(X, (Y + i) + 3, this.colorline);
			}
			//Нижняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 5, this.colorline);
			}
		}
	}
	class Three : Numerics
	{
		public ConsoleColor colorline { get; set; }
		public Three(int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			//Верхняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + 5, Y + i, this.colorline);
			}
			//Средняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 2, this.colorline);
			}
			//Верхняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 5, this.colorline);
			}
		}
	}
	class Four : Numerics
	{
		public ConsoleColor colorline { get; set; }
		public Four(int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			//Вертикальная линия
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + 4, Y + i, this.colorline);
			}
			//Средняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 3, this.colorline);
			}
			//Диагональ
			for (int i = 0; i <= 2; i++)
			{
				Engine.SetPixel((X - i) + 3, Y + i, this.colorline);
			}
		}
	}
	class Five : Numerics
	{
		public ConsoleColor colorline { get; set; }
		public Five(int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			//Верхняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 2; i++)
			{
				Engine.SetPixel(X, Y + i, this.colorline);
			}
			//Средняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 2, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 2; i++)
			{
				Engine.SetPixel(X + 5, (Y + 2) + i, this.colorline);
			}
			//Нижняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 5, this.colorline);
			}
		}
	}
	class Six : Numerics
	{
		public ConsoleColor colorline { get; set; }
		public Six(int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			//Верхняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X, Y + i, this.colorline);
			}
			//Средняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 2, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 2; i++)
			{
				Engine.SetPixel(X + 5, (Y + 2) + i, this.colorline);
			}
			//Нижняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 5, this.colorline);
			}
		}
	}
	class Seven : Numerics
	{
		public ConsoleColor colorline { get; set; }
		public Seven(int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			//Верхняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 2; i++)
			{
				Engine.SetPixel(X + 5, Y + i, this.colorline);
			}
			//Диагональ
			for (int i = 0; i <= 3; i++)
			{
				Engine.SetPixel((X - i) + 5, (Y + 2) + i, this.colorline);
			}
		}
	}
	class Eight : Numerics
	{
		public ConsoleColor colorline { get; set; }
		public Eight(int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			//Верхняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X, Y + i, this.colorline);
			}
			//Средняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 2, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + 5, Y + i, this.colorline);
			}
			//Нижняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 5, this.colorline);
			}
		}
	}
	class Nine : Numerics
	{
		public ConsoleColor colorline { get; set; }
		public Nine(int x, int y, ConsoleColor colorline)
			: base(x, y, colorline)
		{
			this.colorline = colorline;
		}
		public override void Draw()
		{
			//Верхняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 2; i++)
			{
				Engine.SetPixel(X, Y + i, this.colorline);
			}
			//Средняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 2, this.colorline);
			}
			//Вертикальная линия
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + 5, Y + i, this.colorline);
			}
			//Нижняя линия у цифры
			for (int i = 0; i <= 5; i++)
			{
				Engine.SetPixel(X + i, Y + 5, this.colorline);
			}
		}
	}
}
