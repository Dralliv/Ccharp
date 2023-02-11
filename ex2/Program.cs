
float Base;
float Altura;

Console.WriteLine("por favor digite o valor da base do Triangulo ");
Base = float.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o valor da altura do Triangulo ");
Altura = float.Parse(Console.ReadLine());

float area = (Altura*Base)/2;

Console.WriteLine("A área do triangulo é "+area+".");
