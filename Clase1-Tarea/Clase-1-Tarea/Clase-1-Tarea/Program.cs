using Clase_1_Tarea.JuegoNumero;
using System.Security.Cryptography;

string resultado = "";
var juego = new JuegoNumero(55);

do
{

    Console.WriteLine("Ingrese un numero entre 1 y 100:");
    string input = Console.ReadLine();
    int valorJugador = int.Parse(input);

    
    resultado = juego.resultadoJuegoNumero(valorJugador);

    Console.WriteLine(resultado);

} while (resultado != "Ganaste");

if(resultado == "Ganaste") {
    Console.WriteLine("Lo has logrado en el intento " + juego.getIntentos);
}
    



