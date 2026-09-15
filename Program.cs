Compte compte1 = new Compte();
Compte compte2 = new Compte();

compte1.Numero = "001";
compte1.Titulaire = "Adrien";
compte1.Solde = 1000m;

compte2.Numero = "002";
compte2.Titulaire = "Léa";
compte2.Solde = 2000m;

Console.WriteLine($"Compte 1 : {compte1.Numero} - {compte1.Titulaire} - Solde : {compte1.Solde} €");
Console.WriteLine($"Compte 2 : {compte2.Numero} - {compte2.Titulaire} - Solde : {compte2.Solde} €");

compte1.Solde = 1500m;

Console.WriteLine($"Compte 1 après modification : {compte1.Solde} €");
Console.WriteLine($"Compte 2 après modification : {compte2.Solde} €");

