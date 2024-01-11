// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenidos");
Console.WriteLine("--Sistema de control de empleados");
Console.WriteLine("\t 1. Agregar empleados");
Console.WriteLine("\t 2. Listar empleados");
Console.WriteLine("\t 3. Salir");
Console.WriteLine("--SELECCIONE UNA OPCIÓN--");
char Opcion = Char.Parse(Console.ReadLine());
switch (Opcion)
{
    case '1':
        Console.WriteLine("---Agregar Empleado---");
        Console.WriteLine("Ingrese nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese género (M/F)");
        char Genero = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Tipo empleado");
        Console.WriteLine("\t 1. Vendedor");
        Console.WriteLine("\t 2. Gerente");
        string TipoEmpleado = Console.ReadLine();
        Console.WriteLine("Ingrese salario");
        double Salario = double.Parse(Console.ReadLine());

        Console.WriteLine("El nombre del empleado es: " + Nombre);
        Console.WriteLine("El género es: " + Genero);
        Console.WriteLine("El tipo de empleado es: " + TipoEmpleado);
        Console.WriteLine("El salario del empleado es: " + Salario.ToString());
        
        break;
        
    case '2':
        Console.WriteLine("---Listar Empleado---");
        break;

    case '3':
        Environment.Exit(0);
        break;
        
    default:
        Console.WriteLine("Opción inválida");
        break;

}
