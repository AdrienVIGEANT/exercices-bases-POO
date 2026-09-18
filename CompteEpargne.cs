class CompteEpargne : Compte
{
    public decimal TauxInteret { get; set; }

    public CompteEpargne(
        string numero,
        string titulaire,
        decimal solde,
        decimal tauxInteret)
        : base(numero, titulaire, solde)
    {
        TauxInteret = tauxInteret;
    }
}