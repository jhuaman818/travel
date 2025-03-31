using System;
using System.Windows.Input;
using MvvmHelpers;
using travel.Services;
using travel.Views;

namespace travel.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly ApiService _apiService;
        private string _email;
        private string _password;
        private string _message;

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            _apiService = new ApiService();
            LoginCommand = new Command(async () => await LoginAsync());
        }

        private async Task LoginAsync()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                Message = "Por favor, ingrese sus credenciales.";
                return;
            }

            var result = await _apiService.LoginAsync(Email, Password);

            if (result.Success)
            {
                _apiService.SetAuthToken(result.Token);
                await Shell.Current.GoToAsync($"//{nameof(Inicio)}");
            }
            else
            {
                Message = result.Message;
            }
        }
    }
}
