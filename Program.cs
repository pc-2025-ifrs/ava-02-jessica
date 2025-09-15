var f1 = new Fracao(5, 10);
Console.WriteLine(f1.Numerador == 1); // True
Console.WriteLine(f1.Denominador == 2);
Console.WriteLine(f1.ToString() == "1/2");
Console.WriteLine(f1); // 1/2

var f2 = new Fracao(3); // 3 inteiros
Console.WriteLine(f2); // "3/1"

var f3 = new Fracao("30/40"); // Necessário fazer o split e parse da string, ver "".Split e int.Parse
Console.WriteLine(f3.Numerador);
Console.WriteLine(f3.Denominador);
Console.WriteLine(f3.Numerador == 3);
Console.WriteLine(f3.Denominador == 4);
Console.WriteLine(f3); // "3/4"

//bool em fração!
// var f4 = new Fracao(0.345);
// // https://www.wolframalpha.com/input/?i=rationalize+0.345
// Console.WriteLine(f4); // "69/200"

// var f5 = new Fracao(0.4);
// Console.WriteLine(f5.Numerador == 2);
// Console.WriteLine(f5.Denominador == 5);
// Console.WriteLine(f5); // "2/5"

//meus testes
Console.WriteLine("********** Meus testes **********");
Console.WriteLine(f1.Denominador);
Console.WriteLine(f1.Numerador);