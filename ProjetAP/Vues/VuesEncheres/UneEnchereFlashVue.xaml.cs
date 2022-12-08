using ProjetAP.Modeles;
using ProjetAP.VuesModeles.VuesModelesEncheres;

namespace ProjetAP.Vues.VuesEncheres;

public partial class UneEnchereFlashVue : ContentPage
{
	UneEnchereFlashVueModele vueModele;
	public UneEnchereFlashVue(Enchere enchere)
	{
		InitializeComponent();
		BindingContext = vueModele = new UneEnchereFlashVueModele(enchere);
	}

    private void btnRetour_Clicked(object sender, EventArgs e)
    {

		App.Current.MainPage = new EncheresFlashsVue();
    }
}