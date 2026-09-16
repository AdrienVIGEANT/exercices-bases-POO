Produit produit = new Produit("P001", "Clavier", 49.99m);

produit.AjouterStock(10);
produit.RetirerStock(3);

Console.WriteLine($"Référence : {produit.Reference}");
Console.WriteLine($"Nom : {produit.Nom}");
Console.WriteLine($"Prix : {produit.Prix} €");
Console.WriteLine($"Stock : {produit.Stock}");