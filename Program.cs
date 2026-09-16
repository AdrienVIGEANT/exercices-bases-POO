Compte compte = new Compte("FR001", "Alice");

Console.WriteLine($"Compte : {compte.Numero}");
Console.WriteLine($"Titulaire : {compte.Titulaire}");
Console.WriteLine($"Solde : {compte.Solde} €");

compte.Crediter(500m);
compte.Debiter(100m);

Console.WriteLine($"Nouveau solde : {compte.Solde} €");