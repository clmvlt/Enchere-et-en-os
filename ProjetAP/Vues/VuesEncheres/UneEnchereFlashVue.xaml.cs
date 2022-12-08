namespace ProjetAP.Vues.VuesEncheres;

public partial class UneEnchereFlashVue : ContentPage
{
	UneEnchereFlashVue vueModele;
	public UneEnchereFlashVue()
	{
		InitializeComponent();
		BindingContext = vueModele= new UneEnchereFlashVue();
	}
}