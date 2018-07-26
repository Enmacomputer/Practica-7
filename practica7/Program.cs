using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
	class Program
	{
		static void Main(string[] args)
		{
			double dato1, dato2;
			Console.WriteLine("Ingrese primer valor de tipo real:");
			dato1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Ingrese segundo valor de tipo real:");
			dato2 = Convert.ToDouble(Console.ReadLine());

			if (dato2 <= 0)
			{
				Console.WriteLine("ERROR");

			}

			else
			{
				Console.WriteLine("Resultado de la division:" + dato1 / dato2);

			}

			Console.ReadKey();
		}
	}
}
