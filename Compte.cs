class Compte
{
    public string Numero { get; }
    public string Titulaire { get; set; }
    public decimal Solde { get; protected set; }

    public Compte(string numero, string titulaire)
        : this(numero, titulaire, 0m)
    {
    }

    public Compte(string numero, string titulaire, decimal solde)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = solde;
    }

    public void Crediter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Le montant du crédit doit être positif !");
            return;
        }

        Solde += montant;
    }

    public void Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Le montant du débit doit être positif !");
            return;
        }

        if (montant > Solde)
        {
            Console.WriteLine("Solde insuffisant !");
            return;
        }

        Solde -= montant;
    }
}