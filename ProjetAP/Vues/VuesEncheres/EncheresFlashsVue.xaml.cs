using ProjetAP.VuesModeles.VuesModelesEncheres;

namespace ProjetAP.Vues.VuesEncheres;

public partial class EncheresFlashsVue : ContentPage
{
	EncheresFlashsVueModele vueModele;
    public EncheresFlashsVue()
	{
		InitializeComponent();
		vueModele = new EncheresFlashsVueModele();
    }
}