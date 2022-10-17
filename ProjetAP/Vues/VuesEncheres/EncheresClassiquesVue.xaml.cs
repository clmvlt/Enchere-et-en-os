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

	private void Button_Clicked(object sender, EventArgs e)
	{

    }
}