using ProjetAP.Modeles;
using ProjetAP.Services;
using ProjetAP.VuesModeles.VuesModelesEncheres;

namespace ProjetAP.Vues.VuesEncheres;

public partial class UneEnchereInverseeVue : ContentPage
{
	UneEnchereInverseeVueModele vueModele;
    public UneEnchereInverseeVue(Enchere enchere)
	{
		InitializeComponent();
		BindingContext = vueModele = new UneEnchereInverseeVueModele(enchere);

    }

	private void btnRetour_Clicked(object sender, EventArgs e)
	{
		App.Current.MainPage = new EncheresInverseesVue();
	}

	private async void btnAcheter_Clicked(object sender, EventArgs e)
	{
        var res = await APIEnchere.PostEncherirInversee(vueModele.ActualPrice, Session.User, vueModele.Enchere);
    }
}