using CustomControlMaui.Views;

namespace CustomControlMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPageView();
	}
}
