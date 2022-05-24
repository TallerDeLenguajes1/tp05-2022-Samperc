// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero:");
string texto = Console.ReadLine();
Console.WriteLine("salida:" + texto);

int seleccion, fin = 1;
 while (fin != 0)
{
    Console.WriteLine("Seleccione: 1.SUMAR,2.RESTAR,3.PRODUCTO,4.DIVISION \n");
    seleccion = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa dos numeros para operar \n");
    double A = float.Parse(Console.ReadLine());
    double B = float.Parse(Console.ReadLine());
    switch (seleccion)
    {
        case 1:
            Console.WriteLine("SUMAR \n");
            Console.WriteLine(SUMAR(A, B));
            break;
        case 2:
            Console.WriteLine("Restar \n ");
            Console.WriteLine(RESTAR(A, B));
            break;
        case 3:
            Console.WriteLine("Producto \n ");
            Console.WriteLine(PRODUCTO(A, B));
            break;
        case 4:
            Console.WriteLine("Cociente \n ");
            Console.WriteLine(DIVISION(A, B));
            break;
        default:
            break;
    }
    Console.WriteLine("Deseas realizar otro calculo?  1.si 0.no \n");
    fin = int.Parse(Console.ReadLine());
} 
 
Console.WriteLine("Ingrese un valor ");
double C=double.Parse(Console.ReadLine());
Console.WriteLine(Math.Abs(C));
Console.WriteLine(Math.Pow(C,2));
Console.WriteLine(Math.Sqrt(C));
Console.WriteLine(Math.Cos(C));
Console.WriteLine(Math.Sin(C));
Console.WriteLine(Math.Floor(C));

 
Console.WriteLine("Ingrese dos valores ");
 C=double.Parse(Console.ReadLine());
double D=double.Parse(Console.ReadLine());
Console.WriteLine(Math.Max(C,D));
Console.WriteLine(Math.Min(C,D));


double SUMAR(double A, double B)
{
    return A + B;
}
double RESTAR(double A, double B)
{
    return A - B;
}
double PRODUCTO(double A, double B)
{
    return A * B;
}
double DIVISION(double A, double B)
{
    if (B != 0)
    {
        return A / B;
    }
    else
    {
        return -9999999;
    }
}
