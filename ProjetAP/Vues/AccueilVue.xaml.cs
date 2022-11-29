using ProjetAP.VuesModeles;
using ProjetAP.Services;
using ProjetAP.Vues.VuesEncheres;

namespace ProjetAP.Vues;

public partial class AccueilVue : ContentPage
{
	AccueilVueModele vueModele;
	public AccueilVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new AccueilVueModele();
		vueModele.User = Session.User;
	}

	private void btnLogout_Clicked(object sender, EventArgs e) => Session.Logout();

	private void btnAffichageEncheresClassiques_Clicked(object sender, EventArgs e)
	{
		App.Current.MainPage = new EncheresClassiquesVue();
	}

    private void btnAffichageEncheresInversees_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new EncheresInverseesVue();
    }
}