using System;

class Program
{
		static void Main()
		{
			string version = "Version v1.0";
			Console.Title = "IMC Calculator";
			Console.Clear();
			Console.Write("¿Cuanto pesas en kilogramos? ");
			double Peso = double.Parse(Console.ReadLine());
			Console.Clear();
			Console.Write("¿Cuanto mides en metros? ");
			double Altura = double.Parse(Console.ReadLine());
			
			Console.Clear();
			
			Console.WriteLine("Pesas: " + Peso + "kg");
			Console.WriteLine("Mides: " + Altura + "m");
			double imc = Peso / (Altura * Altura);
			
			if (imc <= 18.5) {
				Console.WriteLine($"Tienes un peso bajo con un IMC de: {imc:F1}");
			} else if (imc <= 24.9) {
				Console.WriteLine($"Tienes un peso saludable con una IMC de: {imc:F1}");
			} else if (imc <= 30.0) {
				Console.WriteLine($"Tienes sobrepeso con un IMC de: {imc:F1}");
			} else {
				Console.WriteLine($"Tienes obecidad con un IMC de: {imc:F1}");
			}
			
			Console.ReadKey();
		}
}