using CommunityToolkit.Maui.Alerts;

namespace MauiComm_IssueSnackbar2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnShow_Clicked(object sender, EventArgs e)
    {
		Snackbar snackbar = new Snackbar()
		{
			Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890",
			Action = null,
			Anchor = btnShow,
			ActionButtonText = string.Empty,
			Duration = new TimeSpan(0, 0, 0, 0, 3500),
			VisualOptions = new CommunityToolkit.Maui.Core.SnackbarOptions()
			{
				BackgroundColor = Colors.Red,
				TextColor = Colors.White,
				CornerRadius = new CornerRadius(5),
			}			
		};
		snackbar.Show();
    }
}

