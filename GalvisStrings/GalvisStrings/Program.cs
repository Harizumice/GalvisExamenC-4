// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, USER!");

Console.WriteLine("TARJETA DE IDENTIFICACIÓN \n");
float height = 1.78f;
int year      = 20;
string name   = "Juan David Galvis"; // los espacios también cuentan como carácteres.
string info   = "Nací en Ibagué Tolima, actualmente aprendiz de desarrollo de videojuegos y entornos interactivos";
var hobby     = "Jugar Futboll, Dibujar, ver anime, Programar, Diseñar, pasar tiempo con mis seres queridos";

//string id = $"La información del indivíduo es, " +
//    $"";

string id = $"La información de: {name} es la siguiente...\n" +
    $"su edad es: {year} Años. \n" +
    $"su estatura es: {height} cm. \n" +
    $"descripción: {info}. \n" +
    $"hobbies: {hobby}. \n";

Console.WriteLine(id);