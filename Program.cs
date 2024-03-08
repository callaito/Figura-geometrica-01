// See https://aka.ms/new-console-template for more information

using Geometria;

Console.WriteLine("Figuras Geometricas");
Console.WriteLine();

Console.WriteLine("Cuadrado");
Cuadrado cuadrado = new Cuadrado();
Console.WriteLine("Lado A: ");
cuadrado.LadoA=double.Parse(Console.ReadLine());
Console.WriteLine("Lado B: ");
cuadrado.LadoB=double.Parse(Console.ReadLine());
Console.WriteLine("Traingulo");
Triangulo Triangulo = new Triangulo();
Console.WriteLine("Lado A: ");
Triangulo.LadoA=double.Parse(Console.ReadLine());
Console.WriteLine("Lado B: ");
Triangulo.LadoB=double.Parse(Console.ReadLine());
Console.WriteLine("Lado C: ");
Triangulo.LadoC=double.Parse(Console.ReadLine());


Console.WriteLine("Circulo");
Circulo Circulo = new Circulo();
Console.WriteLine("Radio: ");
Circulo.Radio=double.Parse(Console.ReadLine());





double resultado = cuadrado.CalcularArea();
double perimetro = cuadrado.CalcularPerimetro();

double resultado_triangulo = Triangulo.CalcularArea();
double perimetro_triangulo = Triangulo.CalcularPerimetro();


double resultado_circulo = Circulo.CalcularArea();
double perimetro_circulo = Circulo.CalcularPerimetro();


Console.WriteLine("El área de un cudrado es " + resultado);
Console.WriteLine($"El perimetro del cuadrado es {perimetro}");


Console.WriteLine("El área de un triangulo es " + resultado_triangulo);
Console.WriteLine($"El perimetro del triangulo es {perimetro_triangulo}");



Console.WriteLine("El área de un circulo es " + resultado_circulo);
Console.WriteLine($"El perimetro del circulo es {perimetro_circulo}");


