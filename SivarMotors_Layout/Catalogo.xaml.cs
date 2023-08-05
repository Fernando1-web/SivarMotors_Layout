namespace SivarMotors_Layout;

public partial class Catalogo : ContentPage
{
	public Catalogo()
	{
		InitializeComponent();
	}

    private void Toyota_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Toyota());
    }

    private void Nissan_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Nissan());
    }

    private void Honda_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Honda());
    }
}