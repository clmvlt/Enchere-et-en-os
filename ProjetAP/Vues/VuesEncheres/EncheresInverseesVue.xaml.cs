using ProjetAP.Modeles;
using ProjetAP.VuesModeles.VuesModelesEncheres;

namespace ProjetAP.Vues.VuesEncheres;

public partial class EncheresInverseesVue : ContentPage
{
	EncheresInverseesVueModele vueModele;
    public EncheresInverseesVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new EncheresInverseesVueModele();

    }

	private void btnRetour_Clicked(object sender, EventArgs e)
	{
        App.Current.MainPage = new AccueilVue();
    }

	private void btnViewEnchere_Clicked(object sender, EventArgs e)
	{
        Button btn = sender as Button;
        Enchere selectedEnchere = btn.BindingContext as Enchere;
        App.Current.MainPage = new UneEnchereInverseeVue(selectedEnchere);
    }
}