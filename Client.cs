class Client
{
    public string Nom { get; set; }

    public List<Compte> Comptes { get; }

    public Client(string nom)
    {
        Nom = nom;
        Comptes = new List<Compte>();
    }

    public void AjouterCompte(Compte compte)
    {
        Comptes.Add(compte);
    }
}