namespace Simulacro_MarioLlamaGarcia;

public partial class NuevoTestPage : ContentPage
{
    int count = 0;

    public NuevoTestPage()
	{
		InitializeComponent();


	}

    private void S(object sender, EventArgs e)
    {

    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        /*count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";*/

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}