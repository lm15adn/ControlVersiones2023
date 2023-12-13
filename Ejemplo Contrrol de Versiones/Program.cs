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
        break;

    case '2':
        Console.WriteLine("---Listar Empleado---");
        break;

    case '3':
        Environment.Exit(0);
        
        
    default:
        Console.WriteLine("Opción inválida");
        break;

}
