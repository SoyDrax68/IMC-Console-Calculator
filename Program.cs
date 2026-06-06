using System;

class Program
{
		static void Main()
		{
			string version = "v1.4";
			Console.Title = "IMC Calculator " + version;
			Console.Clear();
			bool running = true;
		
			while (running) {
			Console.WriteLine("1. Start calculator");
			Console.WriteLine("2. Exit");
			Console.WriteLine();
			Console.Write("Select a valid number: ");
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
				Console.WriteLine($"{menuNum} code is not an existing code");
				break;
				}
			}
			
			static void StartCalculator()
			{
				bool start = true;
				while (start) {
				Console.WriteLine("1. International System");
				Console.WriteLine("2. Imperial System");
				Console.WriteLine("3. Exit");
				Console.WriteLine();
				Console.Write("Select a valid number: ");
				string menuNum = Console.ReadLine();
				switch (menuNum) {
					case "1":
					Console.Clear();
					internationalSystem();
					break;
					
					case "2":
					Console.Clear();
					imperialSystem();
					break;
					
					case "3":
					Console.Clear();
					start = false;
					break;
					
					default:
					Console.Clear();
					Console.WriteLine($"{menuNum} code is not an existing code");
					break;
					}
				}
			}
			
			
			static void internationalSystem()
			{
			double Weight;
			double Height;
				
			while (true) {
				Console.Write("How much do you weigh? ");
				
				if (double.TryParse(Console.ReadLine(), out Weight) && Weight > 0 && Weight <= 635) {
					break;
				}
				
				Console.Clear();
				Console.WriteLine("Error: Please enter a valid number or valid weight (1-635 kg).");
				}
			
			Console.Clear();
			
			while (true) {
				Console.Write("How tall are you? ");
				
				if (double.TryParse(Console.ReadLine(), out Height) && Height >= 1.00 && Height <= 2.95) {
					break;
				}
				
				Console.Clear();
				Console.WriteLine("Error: Please enter a valid number or valid height (1.00-2.95 m).");
			}
			
			Console.Clear();
			Console.WriteLine($"Weights: {Weight}kg");
			Console.WriteLine($"Measurements: {Height}m");
			double bmi = Weight / (Height * Height);
			
			if (bmi <= 18.5) {
				Console.WriteLine($"You are underweight with a BMI of: {bmi:F1}");
			} else if (bmi <= 25) {
				Console.WriteLine($"You're at a healthy weight with a BMI of: {bmi:F1}");
			} else if (bmi <= 30) {
				Console.WriteLine($"You are overweight with a BMI of: {bmi:F1}");
			} else {
				Console.WriteLine($"You are obese with a BMI of: {bmi:F1}");
			}
			Console.ReadKey();
			Console.Clear();
			}
			
			static void imperialSystem()
			{
			double Weight;
			int Feet;
			int Inches;

			while (true) {
				Console.Write("How much do you weigh? ");

				if (double.TryParse(Console.ReadLine(), out Weight) && Weight > 0 && Weight <= 1400) {
					break;
				}

				Console.Clear();
				Console.WriteLine("Error: Please enter a valid number or valid weight (1-1400 lb).");
				}
			Console.Clear();

			while (true) {
				Console.WriteLine("How tall are you?");
				Console.Write("Feet: ");

				if (int.TryParse(Console.ReadLine(), out Feet) && Feet >= 3 && Feet <= 9) {
					break;
				}

				Console.Clear();
				Console.WriteLine("Error: Please enter a valid height in feet (3-9).");
				}
			Console.Clear();

			while (true) {
				Console.WriteLine("How tall are you?");
				Console.Write("Additional inches: ");

				if (int.TryParse(Console.ReadLine(), out Inches) && Inches >= 0 && Inches <= 11) {
					break;
				}

				Console.Clear();
				Console.WriteLine("Error: Please enter a valid number of inches (0-11).");
				}

			int TotalInches = (Feet * 12) + Inches;

			double bmi = (Weight * 703) / (TotalInches * TotalInches);

			Console.Clear();

			Console.WriteLine($"Weight: {Weight} lb");
			Console.WriteLine($"Height: {Feet}'{Inches}\"");
    
			if (bmi < 18.5)
			{
				Console.WriteLine($"You are underweight with a BMI of: {bmi:F1}");
			}
			else if (bmi < 25)
			{
				Console.WriteLine($"You're at a healthy weight with a BMI of: {bmi:F1}");
			}
			else if (bmi < 30)
			{
				Console.WriteLine($"You are overweight with a BMI of: {bmi:F1}");
			}
			else
			{
				Console.WriteLine($"You are obese with a BMI of: {bmi:F1}");
			}

			Console.ReadKey();
			Console.Clear();
			}
			
		}	
	
}