
using Android.App;
using Android.OS;
using Android.Widget;
using Core;
using ListaSimple;

namespace Lista
{
    [Activity(Label = "Lista", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Button button = FindViewById<Button>(Resource.Id.MyButton);
            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            var data = Data.GetFilms();

            var listView = FindViewById<ListView>(Resource.Id.listViewPelis);
              listView.Adapter = new FilmsAdapter(this, data);












            //listView.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs args)
            //{
            //    var film = data[args.Position];

            //    var dialog = new AlertDialog.Builder(this);
            //    dialog.SetMessage(film.Name);
            //    dialog.SetNeutralButton("OK", delegate { });
            //    dialog.Show();
            //};

        }
    }
}

