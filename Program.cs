CompteCourant compteCourant =
    new CompteCourant("FR001", "Adrien", 1000m);

CompteEpargne compteEpargne =
    new CompteEpargne("FR002", "Léa", 2000m, 0.03m);

compteCourant.Crediter(500m);
compteEpargne.Debiter(300m);

Console.WriteLine(
    $"Compte courant : {compteCourant.Titulaire} - {compteCourant.Solde} €");

Console.WriteLine(
    $"Compte épargne : {compteEpargne.Titulaire} - {compteEpargne.Solde} € - Taux : {compteEpargne.TauxInteret:P}");