

using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using Core;
using Lista;

namespace ListaSimple
{
    public class FilmsAdapter : BaseAdapter<Film>
    {
        Activity _context;
        List<Film> _films;

        public FilmsAdapter(Activity context, List<Film> films)
        {
            this._context = context;
            this._films = films;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = _context.LayoutInflater.Inflate(Resource.Layout.FilmRow, parent, false);

            var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
            var director = view.FindViewById<TextView>(Resource.Id.directorTextView);

            name.Text = _films[position].Name;
            director.Text = _films[position].Director;

            return view;
        }

        public override int Count
        {
            get { return _films.Count; }
        }

        public override Film this[int position]
        {
            get { return _films[position]; }
        }
    }
}