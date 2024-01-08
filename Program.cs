using DesafioPOO.Models;

// Realizando testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("001", "modeloX1", "0101", 124);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("clash royale");

Iphone iphone = new Iphone("002", "modeloY2", "0202", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ZapZap");