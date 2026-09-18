class CompteCourant : Compte
{
    public CompteCourant(string numero, string titulaire)
        : base(numero, titulaire)
    {
    }

    public CompteCourant(string numero, string titulaire, decimal solde)
        : base(numero, titulaire, solde)
    {
    }
}