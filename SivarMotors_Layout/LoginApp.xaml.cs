namespace SivarMotors_Layout;

public partial class LoginApp : ContentPage
{
	public LoginApp()
	{
		InitializeComponent();
	}

    private void Acceder_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new LoginSuccess());
    }
}