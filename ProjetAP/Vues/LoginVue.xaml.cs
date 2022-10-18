using ProjetAP.Modeles;
using ProjetAP.Services;
using ProjetAP.VuesModeles;
using System.Windows.Input;

namespace ProjetAP.Vues;

public partial class LoginVue : ContentPage
{
    #region Attribus
    LoginVueModele vueModele;
	private bool _isBtnLoginAnimated;
    #endregion

    #region constructeur
    public LoginVue()
	{
		InitializeComponent();

		BindingContext = vueModele = new LoginVueModele();

		_isBtnLoginAnimated = false;
	}

    #endregion

    #region properties

    #endregion

    #region methodes
    private async void btnLogin_Clicked(object sender, EventArgs e)
	{
		this.StartAnimationBtnLogin();
        vueModele.SetErreurMsg(string.Empty);
        var mail = entryMail.Text;
		var pass = entryPass.Text;
		User user = await APIUser.GetUserWithMailAndPass(mail, pass);
		this.StopAnimationBtnLogin();
		if (user == null)
		{
			vueModele.SetErreurMsg("Erreur lors de la connexion.");
        } else
		{
			Session.Login(user);
        }
    }

	private void StartAnimationBtnLogin()
	{
		_isBtnLoginAnimated = true;
		btnLogin.IsEnabled = false;
		Task.Run(() =>
		{
			while (_isBtnLoginAnimated)
			{
				btnLogin.Text = "Chargement.";
                Thread.Sleep(200);
                btnLogin.Text = "Chargement..";
                Thread.Sleep(200);
                btnLogin.Text = "Chargement...";
                Thread.Sleep(200);
            }
		});
	}

	private void StopAnimationBtnLogin()
	{
		_isBtnLoginAnimated = false;
		btnLogin.Text = "Se connecter";
		btnLogin.IsEnabled = true;
	}
    #endregion


}