using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// OK REALIZADO

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("658968596", "Note15", "IMX58965", 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone("56984112", "Iponhe XX", "IMXFGE89", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");