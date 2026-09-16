class Produit
{
    public string Reference { get; }
    public string Nom { get; set; }
    public decimal Prix { get; private set; }
    public int Stock { get; private set; }

    public Produit(string reference, string nom, decimal prix)
    {
        Reference = reference;
        Nom = nom;

        if (prix < 0)
        {
            Prix = 0;
        }
        else
        {
            Prix = prix;
        }

        Stock = 0;
    }

    public void ModifierPrix(decimal prix)
    {
        if (prix >= 0)
        {
            Prix = prix;
        }
    }

    public void AjouterStock(int quantite)
    {
        if (quantite > 0)
        {
            Stock += quantite;
        }
    }

    public void RetirerStock(int quantite)
    {
        if (quantite > 0 && quantite <= Stock)
        {
            Stock -= quantite;
        }
    }
}