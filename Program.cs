// See https://aka.ms/new-console-template for more information
Console.WriteLine("Funciones");

Console.WriteLine("Este texto aparece en el metodo Main");
Console.WriteLine();
Mensaje();
Console.WriteLine();
PedirDatos("Pedro Juan", 20, 5.8);
Console.WriteLine();
int resultado = Suma(25, 48);
Console.WriteLine("El resultado de la suma es " + resultado);
Console.WriteLine("El resultado de la suma es "  + Suma(24, 14));
Console.WriteLine();
string respuesta = MayorDeEdad(24);
Console.WriteLine(respuesta+(24));

//Metodo que no recibe parametros ni devuelve un resultado

static void Mensaje()
{
    Console.WriteLine("Hola a todos, bienvenidos a Desarrollo de aplicaciones");
}
//Metodo que recibe parametros pero no devuelve resultados
static void PedirDatos(string nombre, int edad, double estatura)
{
    Console.WriteLine($"Su nombre es {nombre}, tiene {edad} años y mide {estatura} pies");
}

//Metodo que recibe parametros y retorna un resultado

static int Suma(int n1, int n2)
{
    int resultado = n1 + n2;
    return resultado;

    //segunda forma
    //return n1 + n2;
}


//Metodo que recibe parametro y devuelve resultadi utilizando una condicional
static string MayorDeEdad(int edad)
{
    if(edad >=18)
    {
        return "Es mayor de edad ";
    }
    else
    {
        return "Es menor de edad y su edad es:";
    }
}