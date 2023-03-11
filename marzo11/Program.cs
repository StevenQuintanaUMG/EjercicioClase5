
static bool palindromo(String palabra)
{
    int longitud = palabra.Length;

    string pal = "";
    for (int c = longitud - 1; c >= 0; c--)
    {
        pal = pal + palabra[c].ToString().ToUpper();
    }

    if (palabra.ToUpper().Equals(pal))
    {
        return true;    
    }
    return false;
}

string palabra;
palabra = "Ana";
bool esPalindromo = palindromo("anA");

if (esPalindromo)
{
    Console.WriteLine("Es palindromo");
}
else
{
    Console.WriteLine("nel");
}

//static void marque(String palabra)
//{
//    int longitud = palabra.Length;

//    string pal = "";
//    for (int c = longitud - 1; c >= 0; c--)
//    {
//        pal = pal + palabra[c];
//    }
//}
//    //Console.WriteLine(palabra[2]);

//static void saludar(String nomsal)
//{
//   Console.WriteLine($"Un gran saludo a {nomsal}"); 
//}

////La diferencia entre la una y la otra es que una devuelve valor y la otra no, cuando no
////devuelve valor le vamos a llamar metodo y cuando devuleve un valor es una funcion

//static int calculo_anio_nacimiento(int edad)
//{
//    int anion = 2023 - edad;
//    return anion;
//}

//string nombre;
//int edad;

//Console.Write("Como te llamas?");
//nombre = Console.ReadLine();

//saludar(nombre);    
////Console.WriteLine($"Hola, gusto de saluddarte {nombre}");

//Console.WriteLine("Cuantos años tienes");
//edad = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Bonita edad: {edad} \n naciste en {calculo_anio_nacimiento(edad)}");


