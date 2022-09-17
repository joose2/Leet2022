Console.Write("digite seu nome completo ");
string nomeDigitado = Console.ReadLine()!;
string frase = Console.ReadLine()!;
string codificador = frase
.Replace("A", "4")
.Replace("a", "4")
.Replace("e", "3")
.Replace("E", "3")
.Replace("i", "1")
.Replace("I", "1")
.Replace("L", "1")
.Replace("O", "0")
.Replace("T", "7")
.Replace("S", "5")
.Replace("s", "5");
Console.Write(codificador);
