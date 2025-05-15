namespace Simulacro_MarioLlamaGarcia;

public partial class ListadoTestPage : ContentPage
{
	public ListadoTestPage()
	{
		InitializeComponent();
	}

    private async void OnDetailsClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        //var animal = button?.CommandParameter as Animales;

        //await Navigation.PushAsync(new Datos());
 
    }
}