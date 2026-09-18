Client client1 = new Client("Adrien");
Client client2 = new Client("Léa");

CompteCourant compte1 =
    new CompteCourant("FR001", $"Client : {client1.Nom}", 1000m);

CompteEpargne compte2 =
    new CompteEpargne("FR002", $"Client : {client1.Nom}", 2000m, 0.03m);

CompteCourant compte3 =
    new CompteCourant("FR003", $"Client : {client2.Nom}", 500m);

client1.AjouterCompte(compte1);
client1.AjouterCompte(compte2);

client2.AjouterCompte(compte3);

compte1.Crediter(500m);
compte1.Debiter(100m);

compte2.Crediter(200m);

compte3.Debiter(50m);

Console.WriteLine($"Client : {client1.Nom}");

foreach (Compte compte in client1.Comptes)
{
    Console.WriteLine(
        $"{compte.Numero} - {compte.Titulaire} - {compte.Solde} €");
}

Console.WriteLine();

Console.WriteLine($"Client : {client2.Nom}");

foreach (Compte compte in client2.Comptes)
{
    Console.WriteLine(
        $"{compte.Numero} - {compte.Titulaire} - {compte.Solde} €");
}