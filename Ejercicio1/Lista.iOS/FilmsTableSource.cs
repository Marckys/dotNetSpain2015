using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Foundation;
using UIKit;

namespace Lista.iOS
{
    public class FilmsTableSource : UIKit.UITableViewSource
    {

        private IEnumerable<Film> _films;
        static readonly string FilmCellId = "FilmCell";
        IGrouping<int, Film>[] grouping;

        public FilmsTableSource(IEnumerable<Film> films)
        {
            _films = films;
            grouping = new IGrouping<int, Film>[0];
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return _films.Count(); 
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {

            var cell = tableView.DequeueReusableCell(FilmCellId) ??
                       new UITableViewCell(UITableViewCellStyle.Subtitle, FilmCellId);

            var film = _films.ElementAt(indexPath.Row);
            cell.TextLabel.Text = film.Name;
            cell.DetailTextLabel.Text = film.Director;

            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var film = _films.ElementAt(indexPath.Row);
            new UIAlertView("Film Seleccionada: ", film.Name, null, "OK", null).Show();

            tableView.DeselectRow(indexPath, true);
        }
		
    }
}
