namespace SivarMotors_Layout;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}

    private void BtnSignUp_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new SignUpSucess());
    }
}