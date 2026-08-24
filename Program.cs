Console.Write("Ingresa el primer numero: ");
var primero = Console.ReadLine();

Console.Write("Ingresa el segundo numero: ");
var segundo = Console.ReadLine();

if (int.TryParse(primero,out int entrada1) && int.TryParse(segundo, out int entrada2)) {
    if (entrada1 > entrada2){ 
        Console.Write($"El primer numero es mayor, el {entrada1}");
    }
    else if (entrada2 > entrada1) {
    Console.Write($"El segundo es mayor, el {entrada2}");}
    else{
    Console.Write("Son iguales");
    }
}
else {
    Console.Write("Error");
}