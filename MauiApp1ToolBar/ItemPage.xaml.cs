namespace MauiApp1ToolBar;

public partial class ItemPage : ContentPage
{
	public ItemPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new DetailsPage ());	
    }
}