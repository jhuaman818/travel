using travel.ViewModels;

namespace travel.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}