Console.WriteLine("Ingresa la primera nota: ");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingresa la tercera nota: ");
float nota3 = float.Parse(Console.ReadLine());

float promedio = (nota1 + nota2 + nota3) / 3;
Console.WriteLine(promedio);
string alu = "";

if (promedio >= 11)
    alu = "Esta aprobado";
else
    alu = "Esta desaprobado";

Console.WriteLine(alu);