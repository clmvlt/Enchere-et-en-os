using ProjetAP.Modeles;
using ProjetAP.Services;
using ProjetAP.VuesModeles.VuesModelesEncheres;

namespace ProjetAP.Vues.VuesEncheres;

public partial class UneEnchereClassiqueVue : ContentPage
{
	UneEnchereClassiqueVueModele vueModele;
    public UneEnchereClassiqueVue(Enchere enchere)
	{
		InitializeComponent();
		BindingContext = vueModele = new UneEnchereClassiqueVueModele(enchere);

    }

	private void btnRetour_Clicked(object sender, EventArgs e)
	{
		App.Current.MainPage = new EncheresClassiquesVue();
	}

	private async void btnEcherir_Clicked(object sender, EventArgs e)
	{
		AnimationEntryEncherir();
		btnEcherir.IsEnabled = false;
		float montant = float.Parse(entryEncherir.Text.Replace('.', ','));
		var bg = entryEncherir.BackgroundColor;
		if (vueModele.ActualPrice>montant)
		{
			entryEncherir.BackgroundColor = Colors.Red;
		}
		await APIEnchere.PostEncherir(montant, Session.User, vueModele.Enchere);
		vueModele.AfficherLastSixOffers();
		entryEncherir.Text = String.Empty;
        btnEcherir.IsEnabled = true;
		entryEncherir.BackgroundColor = bg;
    }

	private async void AnimationEntryEncherir()
	{
		await entryEncherir.TranslateTo(5, 0, 30);
		for (int i = 0; i < 3; i++) 
		{
			await entryEncherir.TranslateTo(-5, 0, 60);
			await entryEncherir.TranslateTo(5, 0, 60);
		}
        await entryEncherir.TranslateTo(0, 0, 30);
    }
}