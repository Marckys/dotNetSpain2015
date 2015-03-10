

using System;
using Core;
using Xamarin.Forms;

namespace Forms.Lista.Pages
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            var data = Data.GetFilms();
            FilmsListView.ItemsSource = data;

            
            FilmsListView.ItemTemplate = new DataTemplate(()=>
            {
                    var template = new TextCell();
                    template.SetBinding(TextCell.TextProperty, "Name");
                    template.SetBinding(TextCell.DetailProperty, "Director");
                     return template;
            });

        }
    }
}
