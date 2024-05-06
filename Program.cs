
int opcion;
opcion = ingresarOpcion();

while (opcion != 4)
{
switch(opcion)
{
    case 1:
        SuperHeroe superHeroe1;
        superHeroe1 = ingresarSuperheroe();
    break;

    case 2:
        SuperHeroe superHeroe2;
        superHeroe2 = ingresarSuperheroe();
    break;

    case 3:

    break;
}
    opcion = ingresarOpcion();
}





static int ingresarOpcion()
{
    int opcion;
    do
    {
        Console.WriteLine("1. Cargar Datos Superhéroe 1");
        Console.WriteLine("2. Cargar Datos Superhéroe 2");
        Console.WriteLine("3. Competir! ");
        Console.WriteLine("4. Salir ");
        opcion = int.Parse(Console.ReadLine());
    } while(opcion > 4 || opcion < 1);
    return opcion;
}
static SuperHeroe ingresarSuperheroe()
{
    double peso, fuerza, velocidad;
    string ciudad, nombre;
    Console.WriteLine("Ingrese el nombre");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese la ciudad");
    ciudad = Console.ReadLine();
    Console.WriteLine("Ingrese el peso");
    peso = double.Parse(Console.ReadLine());
    do
    {
        Console.WriteLine("Ingrese el velocidad");
        velocidad = double.Parse(Console.ReadLine());
    } while (velocidad > 100 || velocidad < 1);
    do
    {       
        Console.WriteLine("Ingrese la fuerza");
        fuerza = double.Parse(Console.ReadLine());

    } while (fuerza < 1 || fuerza > 100);
    
    SuperHeroe superheroe = new SuperHeroe (nombre,  ciudad,  peso,  fuerza,  velocidad);
    return superheroe;
}
static void Competir(SuperHeroe superHeroe1, SuperHeroe superHeroe2)
{
    SuperHeroe ganador = null, perdedor = null;
    if(superHeroe1 != null && superHeroe2 != null)
    {
        if(superHeroe1.ObtenerSkill() > superHeroe2.ObtenerSkill())
    {
        ganador = superHeroe1;
        perdedor = superHeroe2;
    }
    else if(superHeroe1.ObtenerSkill() < superHeroe2.ObtenerSkill())
    {
        ganador = superHeroe2;
        perdedor = superHeroe1;
    }
    else
    Console.WriteLine("Empate!");

    if (ganador.ObtenerSkill() - perdedor.ObtenerSkill() > 30 )
    Console.WriteLine("Ganó" +  ganador  + "por amplia diferencia");
    else if(ganador.ObtenerSkill() - perdedor.ObtenerSkill() > 10 &&  ganador.ObtenerSkill() - perdedor.ObtenerSkill() < 30) 
    Console.WriteLine("Ganó" +  ganador  + ", pero fue muy parejo");
    else 
    Console.WriteLine("Ganó" +  ganador  + ", pero no le sobró nada");
    }
    else
    Console.WriteLine("Se deben ingresar los datos de ambos superheroes");
}   
