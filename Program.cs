using System;

class Program
{
		static void Main()
		{
			string version = "v1.1";
			Console.Title = "IMC Calculator " + version;
			Console.Clear();
			double Peso;
			double Altura;
			
			while (true) {
				Console.Write("¿Cuanto pesas en kilogramos? ");
				
				if (double.TryParse(Console.ReadLine(), out Peso)) {
					break;
				}
				
				Console.Clear();
				Console.WriteLine("Error: introduce un numero valido.");
			}
			
			Console.Clear();
			
			while (true) {
				Console.Write("¿Cuanto mides en metros? ");
				
				if (double.TryParse(Console.ReadLine(), out Altura)) {
					break;
				}
				
				Console.Clear();
				Console.WriteLine("Error: introduce un numero valido.");
			}
			
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