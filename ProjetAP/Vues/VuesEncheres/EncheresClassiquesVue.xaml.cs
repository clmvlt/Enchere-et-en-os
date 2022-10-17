using ProjetAP.Modeles;
using ProjetAP.Services;
using ProjetAP.VuesModeles.VuesModelesEncheres;

namespace ProjetAP.Vues.VuesEncheres;

public partial class EncheresClassiquesVue : ContentPage
{
	EncheresClassiquesVueModele vueModele;
    public EncheresClassiquesVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new EncheresClassiquesVueModele();
    }

	private void btnViewEnchere_Clicked(object sender, EventArgs e)
	{
		Button btn = sender as Button;
		Enchere selectedEnchere = btn.BindingContext as Enchere;
	}
}