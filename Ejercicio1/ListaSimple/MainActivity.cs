
using Android.App;
using Android.Widget;
using Android.OS;

namespace ListaSimple
{
    [Activity(Label = "ListaSimple", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private string[] _peliculas = { 
                                          "Birdman", 
                                          "El gran hotel Budapest", 
                                          "The imitation game",
                                          "Boyhood"};

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var listAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, _peliculas);
            var listView = FindViewById<ListView>(Resource.Id.listPelis);

            listView.Adapter = listAdapter;

        }
    }
}

