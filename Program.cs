using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Testando todos os métodos e propriedades do Nokia
Nokia N1 = new Nokia("1111", "Nokia C21 Plus", "4444xxx4444", 64);
N1.Ligar();
N1.ReceberLigacao();
Console.WriteLine(N1.Numero);
N1.ExibirModelo();
N1.ExibirIMEI();
N1.ExibirMemoria();
N1.InstalarAplicativo("Duolingo");

// Testando todos os métodos e propriedades do Iphone
Iphone I1 = new Iphone("2222", "Iphone 14", "777xxx777", 128);
I1.Ligar();
I1.ReceberLigacao();
Console.WriteLine(I1.Numero);
I1.ExibirModelo();
I1.ExibirIMEI();
I1.ExibirMemoria();
I1.InstalarAplicativo("Duolingo");