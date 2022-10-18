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
		float montant = int.Parse(entryEncherir.Text);
		await APIEnchere.PostEncherir(montant, Session.User, vueModele.Enchere);
		vueModele.AfficherLastSixOffers();
	}
}