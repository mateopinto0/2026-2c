int intentosIniciales = 6;
int intentos = intentosIniciales;

Console.WriteLine("Bienvenido al juego del ahorcado.");
Console.WriteLine($"Tendras {intentosIniciales} intentos para adivinar la palabra secreta!");

//Juego Ahorcado

// Palabras para el juego
string[] palabras = { "programacion", "consola", "csharp", "desarrollo", "juego" };

//Elegir una palabra al azar
Random rand = new Random();
string palabraSecreta = palabras.OrderBy(x => rand.Next()).ToArray()[0];
//Mostrar la cantidad de letras de la palabra
string palabraOculta = new string('_', palabraSecreta.Length);
Console.WriteLine();

do
{
    Console.WriteLine(palabraOculta.Replace("_", " _"));
    //Pedir al usuario que ingrese una letra
    char letraIngresada = Console.ReadKey().KeyChar;
    Console.WriteLine();

    // Verificar si la letra está en la palabra
    if (palabraSecreta.Contains(letraIngresada))
    {
        // Mostrar la letra en su posición correspondiente
        for (int i = 0; i < palabraSecreta.Length; i++)
        {
            if (palabraSecreta[i] == letraIngresada)
            {
                palabraOculta = palabraOculta.Remove(i, 1).Insert(i, letraIngresada.ToString());
            }
        }
    }
    else
    {
        // Restar un intento
        Console.WriteLine("Letra incorrecta. Intentos restantes: " + (--intentos));
    }
}
while (intentos > 0 && palabraOculta.Contains('_'));

Console.WriteLine();
if (palabraOculta.Contains('_'))
{
    Console.WriteLine($"GAME OVER. Se han utilizado todos los {intentosIniciales} intentos...");
}
else
{
    Console.WriteLine("¡Felicidades! Has adivinado la palabra: " + palabraSecreta);
}


