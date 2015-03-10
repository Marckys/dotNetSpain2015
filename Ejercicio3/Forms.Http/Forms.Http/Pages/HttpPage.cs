using Forms.Http.Service;
using Xamarin.Forms;

namespace Forms.Http.Pages
{
    public class HttpPage : ContentPage
    {
        public HttpPage()
        {

            GetCities();
            
          
            Content = new StackLayout
            {
                Children = {
					new Label { Text = "Hello ContentPage" }
				}
            };
        }

        private async void GetCities()
        {
            var service = new CityService();
            var cities = await service.GetCities();
            var test = "";
        }

    }
}
