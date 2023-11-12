// See https://aka.ms/new-console-template for more information
using OOP3;
using System.Collections.Generic;

 Console.WriteLine("Hello, World!");

//interfaceler de o interfacei implemente eden classların
//referans numarasını tutabilir.

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasıtKrediManager = new TasıtKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
ILoggerSercive databaseLoggerService = new DatabaseLoggerService();
ILoggerSercive fileloggerService = new FileLoggerService();

BasvuruManager basvuruManager=new BasvuruManager();
basvuruManager.BasvuruYap(tasıtKrediManager, databaseLoggerService);

List<IKrediManager> krediler = new List<IKrediManager>() 
{ihtiyacKrediManager,tasıtKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);