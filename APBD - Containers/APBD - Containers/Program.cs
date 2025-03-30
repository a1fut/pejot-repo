// See https://aka.ms/new-console-template for more information

using APBD___Containers;

LiquidContainer lq1 = new LiquidContainer(10.2,123.2,23.4,100,false);
LiquidContainer lq2 = new LiquidContainer(10.2,123.2,23.4,100,true);


GasContainer gasContainer = new GasContainer(10.2,123.2,23.4,100);

Console.WriteLine(lq1.serial);
Console.WriteLine(lq2.serial);

gasContainer.notify();
