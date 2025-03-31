using travel.Models;
using Microsoft.Maui.Controls;

namespace travel.Views;

[QueryProperty(nameof(Destination), "destination")]
public partial class DestinationDetail : ContentPage
{
    private Destination _destination;

    public Destination Destination
    {
        get => _destination;
        set
        {
            _destination = value;
            BindingContext = _destination;
        }
    }
    public DestinationDetail()
    {
        InitializeComponent(); // ⬅️ Esto debe reconocerse
    }

    //public DestinationDetail(Destination destination)
    //{
     //   InitializeComponent();
     //   BindingContext = destination;
    //}
}
