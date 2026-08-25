using System;

Console.WriteLine("Bienvenido a mi calculadora");
Console.Write("Escribe la operacion que deseas realizar o elige una de las opciones: ");
var datos = Console.ReadLine();
decimal operacion;
bool siono =decimal.TryParse(datos, out operacion);
char operador = ' ';

if (datos.Contains("+")) { operador = '+'; }
else if (datos.Contains("-")) { operador = '-'; }
else if (datos.Contains("*")) { operador = '*'; }
else if (datos.Contains("/")) { operador = '/'; }

if (siono) {
    Console.WriteLine("Es un numero. Elegiste una opcion del menu");
}
else if (operador != ' '){
    string[] numeros = datos.Split(operador); //separa los datos y los guarda
    decimal numero0; //este es el espacio vacio prstado
    decimal numero1;
    bool valido0 = decimal.TryParse(numeros[0],out numero0); //numeros[0] tiene el numero en str
    bool valido1 = decimal.TryParse(numeros[1],out numero1); //out numero0 usa el espacio prestado 
    if (valido0 && valido1){
        decimal resultado = 0;
        if (operador == '+') {resultado= numero0 + numero1;}
        else if (operador == '-') {resultado= numero0 - numero1;}
        else if (operador == '*') {resultado= numero0 * numero1;}
        else if (operador == '/') {
            if (numero1 == 0) {
                Console.WriteLine("No se puede");
                }
            else {
            resultado= numero0 / numero1;}
        }
        Console.WriteLine($"Tu resultado es: {resultado}");
    }
    else {
        Console.WriteLine("No es correcto");
    }
}
else{
    Console.WriteLine("No entendi lo que escribiste");
}

