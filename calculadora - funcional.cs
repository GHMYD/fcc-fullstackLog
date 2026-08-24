using System;

Console.WriteLine("Bienvenido a mi calculadora");
Console.Write("Escribe la operacion que deseas realizar o elige una de las opciones: ");
var datos = Console.ReadLine();
decimal operacion;
bool siono =decimal.TryParse(datos, out operacion);
char operador = ' ';
if (siono) {
    Console.WriteLine("Es un numero. Elegiste una opcion del menu");
}
else if (datos.Contains("+")){ operador = '+';
    string[] numeros = datos.Split('+');
    decimal numero0;
    decimal numero1;
    bool valido0 = decimal.TryParse(numeros[0],out numero0);
    bool valido1 = decimal.TryParse(numeros[1],out numero1);
    if (valido0 && valido1){
        decimal suma = numero0 + numero1;
        Console.WriteLine($"Tu resultado es: {suma}");
    }
    else {
        Console.WriteLine("No es correcto");
    }
}
else if (datos.Contains("-")){ operador = '-';
    string[] numeros = datos.Split('-');
    decimal numero0;
    decimal numero1;
    bool valido0 = decimal.TryParse(numeros[0],out numero0);
    bool valido1 = decimal.TryParse(numeros[1],out numero1);
    if (valido0 && valido1){
        decimal resta = numero0 - numero1;
        Console.WriteLine($"Tu resultado es: {resta}");
    }
    else {
        Console.WriteLine("No es correcto");
    }
}
else if (datos.Contains("*")){ operador = '*';
    string[] numeros = datos.Split('*');
    decimal numero0;
    decimal numero1;
    bool valido0 = decimal.TryParse(numeros[0],out numero0);
    bool valido1 = decimal.TryParse(numeros[1],out numero1);
    if (valido0 && valido1){
        decimal multiplicacion = numero0 * numero1;
        Console.WriteLine($"Tu resultado es: {multiplicacion}");
    }
    else {
        Console.WriteLine("No es correcto");
    }
}
else if (datos.Contains("/")){ operador = '/';
    string[] numeros = datos.Split('/');
    decimal numero0;
    decimal numero1;
    bool valido0 = decimal.TryParse(numeros[0],out numero0);
    bool valido1 = decimal.TryParse(numeros[1],out numero1);
    if (valido0 && valido1){
        decimal division = numero0 / numero1;
        Console.WriteLine($"Tu resultado es: {division}");
    }
    else {
        Console.WriteLine("No es correcto");
    }
}
else{
    Console.WriteLine("No entendi lo que escribiste");
}

