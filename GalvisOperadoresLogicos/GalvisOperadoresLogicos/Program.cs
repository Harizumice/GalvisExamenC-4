// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// && and
// || or
// ! not
// xor ^ (alt+94)

var (value1, value2, value3) = (true, true, false);

// &&
bool result = value1 && value2;
Console.WriteLine("&&: "+result);

// ||
result = value1 || value2 || value3;
Console.WriteLine("||: "+result);

// and+or
result = (value1 && value2) || value3;
Console.WriteLine("&& ||: "+result);

// !
result = (!value1);
Console.WriteLine("!: "+result);

// xor
result = (value1 ^ value2);
Console.WriteLine("xor ^: "+result);

result = (value1 ^ value2 ^ value3);
Console.WriteLine("2do xor ^: " + result);

