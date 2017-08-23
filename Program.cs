using System;

namespace Lista21082017ex07
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			decimal nota1, nota2, nota3, media;

			Console.Write("Digite a nota 1: ");
			nota1 = Convert.ToDecimal(Console.ReadLine());
			Console.Write("Digite a nota 2: ");
			nota2 = Convert.ToDecimal(Console.ReadLine());
			Console.Write("Digite a nota 3: ");
			nota3 = Convert.ToDecimal(Console.ReadLine());

            media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;
			
			Console.Write("A média final é {0:##,##0.00}", media);
		
			Console.ReadLine();
        }
    }
}
