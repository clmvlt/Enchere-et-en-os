using ProjetAP.Services;
using ProjetAP.Vues;
﻿using ProjetAP.Vues;

namespace ProjetAP;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginVue();
	}
}
