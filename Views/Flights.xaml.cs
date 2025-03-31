using travel.ViewModels;

namespace travel.Views;

public partial class Flights : ContentPage
{
	public Flights()
	{
		InitializeComponent();
        BindingContext = new FlightViewModel();
    }
}