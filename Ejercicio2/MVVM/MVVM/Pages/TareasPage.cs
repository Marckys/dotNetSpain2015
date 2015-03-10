using System;
using MVVM.ViewModels;
using Xamarin.Forms;

namespace MVVM.Pages
{
    public class TareasPage : ContentPage
    {
        private TareasViewModel _viewModel;

        public TareasPage()
        {

            BindingContext =  _viewModel = new TareasViewModel();

            var layout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(0,40,0,0)
            };


            var entry = new Entry{ Placeholder = "Introduce tu tarea"};
            entry.SetBinding(Entry.TextProperty, "Tarea");


            var btn = new Button {Text = "Añadir",  WidthRequest = 150};
            btn.Clicked += delegate(object sender, EventArgs args)
            {
                _viewModel.Add.Execute(null);
            };

            var lista = new ListView {};
            lista.SetBinding(ListView.ItemsSourceProperty, "List");
            lista.ItemTemplate = new DataTemplate(() =>
            {
                var template =new TextCell();
                template.SetBinding(TextCell.TextProperty, "Name");
                template.SetBinding(TextCell.DetailProperty, "Time");
                return template;
            });



            layout.Children.Add(new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = {  entry, btn}
            });
            layout.Children.Add(lista);

            

            Content = layout;
        }
    }
}
