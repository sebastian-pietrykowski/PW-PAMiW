using P12MAUI.Client.ViewModels;

namespace P12MAUI.Client;

public partial class MovieDetailsView : ContentPage
{
	public MovieDetailsView(MovieDetailsViewModel movieDetailsViewModel)
	{
		BindingContext = movieDetailsViewModel;
		InitializeComponent();
	}
}