Console.WriteLine("Введите число");

string input = Console.ReadLine(); // ввод

int number = int.Parse(input); // число
// double.Parse

// if(int.TryParse (input))

int square = number * number; // квадрат

Console.WriteLine($"Число в квадрате = {square}");
// Console.WriteLine("Число в квадрате = {0}, square);
