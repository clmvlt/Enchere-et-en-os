using ProjetAP.Modeles;
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
}