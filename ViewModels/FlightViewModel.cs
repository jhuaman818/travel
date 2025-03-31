using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using travel.Models;


namespace travel.ViewModels
{
    class FlightViewModel : BaseViewModel
    {
        public ObservableCollection<Flights> Flights { get; set; }
        public List<string> Cities { get; set; }
        public List<int> TicketOptions { get; set; }

        private string _selectedCity;
        public string SelectedCity
        {
            get => _selectedCity;
            set => SetProperty(ref _selectedCity, value);
        }

        private int _selectedTickets = 1;
        public int SelectedTickets
        {
            get => _selectedTickets;
            set => SetProperty(ref _selectedTickets, value);
        }

        private DateTime _departureDate = DateTime.Today;
        public DateTime DepartureDate
        {
            get => _departureDate;
            set => SetProperty(ref _departureDate, value);
        }

        private DateTime _returnDate = DateTime.Today.AddDays(7);
        public DateTime ReturnDate
        {
            get => _returnDate;
            set => SetProperty(ref _returnDate, value);
        }
        public FlightViewModel()
        {
            Cities = new List<string> { "Ottawa, Canada", "New York, USA", "Buenos Aires, Argentina" };
            TicketOptions = new List<int> { 1, 2, 3, 4, 5 };

            // Datos de prueba
            Flights = new ObservableCollection<Flights>
        {
            new Flights { Code_Origin = "JFK", From_City = "New York", Code_Destination = "EZE", To_City = "Buenos Aires", Departure_Time = "10:30", Arrival_Time  = "23:30", Price = 1000 },
            new Flights { Code_Origin = "JFK", From_City = "New York", Code_Destination = "EZE", To_City = "Buenos Aires", Departure_Time = "09:30", Arrival_Time  = "22:45", Price = 1500 },
            new Flights { Code_Origin = "JFK", From_City = "New York", Code_Destination = "EZE", To_City = "Buenos Aires", Departure_Time = "11:45", Arrival_Time  = "01:30", Price = 1200 },
        };
        }
    }
}
