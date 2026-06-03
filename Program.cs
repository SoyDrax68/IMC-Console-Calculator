using System;

class Program
{
		static void Main()
		{
			string version = "v1.2";
			Console.Title = "IMC Calculator " + version;
			Console.Clear();
			bool running = true;
		
			while (running) {
			Console.WriteLine("1. Iniciar Calculadora");
			Console.WriteLine("2. Salir");
			Console.WriteLine("");
			Console.Write("Seleccionar un numero valido: ");
			string menuNum = Console.ReadLine();
			switch (menuNum) {
				case "1":
				Console.Clear();
				StartCalculator();
				running = false;
				break;
				
				case "2":
				running = false;
				break;
				
				default:
				Console.Clear();
				
				Console.WriteLine($"Codigo {menuNum} no es un codigo existente");
				break;
				}
			}
			
			
			static void StartCalculator()
			{
			double Weight;
			double Height;
				
			while (true) {
				Console.Write("¿Cuanto pesas en kilogramos? ");
				
				if (double.TryParse(Console.ReadLine(), out Weight) && Weight > 0 && Weight <= 635) {
					break;
				}
				
				Console.Clear();
				Console.WriteLine("Error: introduce un numero valido o peso valido (1-635 kg).");
				}
			
			Console.Clear();
			
			while (true) {
				Console.Write("¿Cuanto mides en metros? ");
				
				if (double.TryParse(Console.ReadLine(), out Height) && Height >= 1.00 && Height <= 2.95) {
					break;
				}
				
				Console.Clear();
				Console.WriteLine("Error: introduce un numero valido 0 altura valida (1.00-2.95 m).");
			}
			
			Console.Clear();
			Console.WriteLine($"Pesas: {Weight}kg");
			Console.WriteLine($"Mides: {Height}m");
			double imc = Weight / (Height * Height);
			
			if (imc <= 18.5) {
				Console.WriteLine($"Tienes un peso bajo con un IMC de: {imc:F1}");
			} else if (imc <= 24.9) {
				Console.WriteLine($"Tienes un peso saludable con una IMC de: {imc:F1}");
			} else if (imc <= 30.0) {
				Console.WriteLine($"Tienes sobrepeso con un IMC de: {imc:F1}");
			} else {
				Console.WriteLine($"Tienes obecidad con un IMC de: {imc:F1}");
			}
			}
			Console.ReadKey();
		}
}