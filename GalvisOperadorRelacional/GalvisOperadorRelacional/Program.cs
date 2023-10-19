var (value1, value2, value3) = (64, 64, 24);
Console.WriteLine("Mis valores son: " +value1+" "+value2+" "+value3);
// == igual a
// != diferente o no es igual
// > mayor a 
// < menor que
// >= mayor o igual
// <= menor o igual
// <> menor o mayor.

// ==
bool result = value1 == value2;
Console.WriteLine("== igual a: "+result);

// != 
result = value1 != value2;
Console.WriteLine("!= diferente o no es igual: " + result);

// >
result = value1 > value2;
Console.WriteLine("> mayor a : " + result);

// <
result = value1 < value2;
Console.WriteLine("< menor a: " + result);

// >=
result = value1 >= value2;
Console.WriteLine("> mayor o igual a : " + result);

// <=
result = value1 <= value2;
Console.WriteLine("< menor o igual a: " + result);