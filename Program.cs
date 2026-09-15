Compte compte = new Compte();

compte.Numero = "001";
compte.Titulaire = "Adrien";
compte.Solde = 1000m;

Console.WriteLine($"Solde initial : {compte.Solde} €");

compte.Crediter(200m);
compte.Debiter(50m);

Console.WriteLine($"Solde final : {compte.Solde} €");