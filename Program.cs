// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


ComplexNumber num1 = new ComplexNumber();
ComplexNumber num2 = new ComplexNumber();
num1 = ComplexNumber.Parse("18 + 20i");
num2 = ComplexNumber.Parse("4 + 3i");

ComplexNumber num3 = num1 + num2;
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);


