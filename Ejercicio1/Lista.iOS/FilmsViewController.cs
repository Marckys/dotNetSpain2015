using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Foundation;
using UIKit;

namespace Lista.iOS
{
    public class FilmsViewController : UITableViewController
    {
        List<Film> films;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            films = Data.GetFilms();
            TableView.Source = new FilmsTableSource(films);
            TableView.ContentInset = new UIEdgeInsets(20, 0, 0, 0);
        }
    }
}