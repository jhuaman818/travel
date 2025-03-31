using travel.ViewModels;
using travel.Models;
using Destination = travel.Models.Destination;

namespace travel.Views;

public partial class Inicio : ContentPage
{
    public Inicio()
    {
        InitializeComponent();
        BindingContext = new InicioViewModel();
    }
    //private async void OnDestinationSelected(object sender, SelectionChangedEventArgs e)
    //{
    //    if (e.CurrentSelection.FirstOrDefault() is Destination selectedDestination)
     //   {
     //       ((CollectionView)sender).SelectedItem = null;
      //      await Navigation.PushAsync(new DestinationDetail(selectedDestination));
      //  }
    //}
    private async void OnDestinationSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Destination selectedDestination)
        {
            ((CollectionView)sender).SelectedItem = null; // Deseleccionar

            // Navegar a la página de detalles pasando el objeto seleccionado
            await Shell.Current.GoToAsync(nameof(DestinationDetail), true, new Dictionary<string, object>
            {
                { "destination", selectedDestination }
            });
        }
    }


}
