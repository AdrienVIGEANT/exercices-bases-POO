decimal solde = 1000m;      // Solde initial du compte
decimal montant = 1500m;   // Montant de l'opération (positif = crédit, négatif = débit)

// Si le montant est positif, on fait un crédit
if (montant > 0)
{
    solde = Crediter(solde, montant);
}
// Si le montant est négatif, on fait un débit
else if (montant < 0)
{
    solde = Debiter(solde, -montant);
}

Console.WriteLine($"Solde : {solde}");

/// Ajoute un montant au solde.
static decimal Crediter(decimal solde, decimal montant)
{
    if (montant <= 0)
    {
        Console.WriteLine("Le montant du crédit doit être positif !");
        return solde;
    }

    return solde + montant;
}

/// Retire un montant du solde.
static decimal Debiter(decimal solde, decimal montant)
{
    if (montant <= 0)
    {
        Console.WriteLine("Le montant du débit doit être positif !");
        return solde;
    }

    if (montant > solde)
    {
        Console.WriteLine("Solde insuffisant !");
        return solde;
    }

    return solde - montant;
}