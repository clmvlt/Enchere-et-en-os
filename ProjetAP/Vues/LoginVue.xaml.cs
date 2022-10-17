using ProjetAP.Modeles;
using ProjetAP.Services;
using ProjetAP.VuesModeles;


namespace ProjetAP.Vues;

public partial class LoginVue : ContentPage
{
	LoginVueModele vueModele;
	public LoginVue()
	{
		InitializeComponent();

		BindingContext = vueModele = new LoginVueModele();
	}

	private async void btnLogin_Clicked(object sender, EventArgs e)
	{
		var mail = entryMail.Text;
		var pass = entryPass.Text;
		User user = await APIUser.GetUserWithMailAndPass(mail, pass);
		if (user == null)
		{
			vueModele.ErreurMsg = "Erreur lors de la connexion.";
        } else
		{
			Session.Login(user);
        }
    }

	private void btnSignIn_Clicked(object sender, EventArgs e)
	{
		App.Current.MainPage = new SingInVue();
	}
}