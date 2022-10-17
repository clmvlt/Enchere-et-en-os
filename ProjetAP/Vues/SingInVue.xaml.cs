using ProjetAP.Modeles;
using ProjetAP.Services;
using ProjetAP.VuesModeles;

namespace ProjetAP.Vues;

public partial class SingInVue : ContentPage
{
	SignInVueModele vueModele;
	public SingInVue()
	{
		InitializeComponent();

		BindingContext = vueModele = new SignInVueModele();
	}

	private async void btnSignIn_Clicked(object sender, EventArgs e)
	{
		var mail = entryMail.Text;
		var pass = entryPass.Text;
		var photo = entryPhoto.Text;
		var pseudo = entryPseudo.Text;
		var id = await APIUser.CreateUser(new User(0, mail, pass, pseudo, photo));
		if (id > 0)
		{
			vueModele.ResEnr = "Compté créé";
		} else
		{
            vueModele.ResEnr = "Impossible de créer le compte";
        }
    }

	private void btnBack_Clicked(object sender, EventArgs e)
	{
		App.Current.MainPage = new LoginVue();
	}
}