using ProjetAP.Modeles;
using ProjetAP.Services;
using ProjetAP.VuesModeles;
using System.Windows.Input;

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
        vueModele.SetErreurMsg(string.Empty);
        var mail = entryMail.Text;
		var pass = entryPass.Text;
		User user = await APIUser.GetUserWithMailAndPass(mail, pass);
		if (user == null)
		{
			vueModele.SetErreurMsg("Erreur lors de la connexion.");
        } else
		{
			Session.Login(user);
        }
    }
}