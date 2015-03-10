
using System;
using System.Collections.ObjectModel;
using MVVM.Models;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class TareasViewModel : BaseViewModel
    {

        private ObservableCollection<Tarea> _list;

        public TareasViewModel()
        {
            _list = new ObservableCollection<Tarea>
            {
                new Tarea {Name = "Test ViewModel", Time = DateTime.Now}
            };

        }


        private string _tarea;
        public string Tarea
        {
            get { return _tarea; }
            set
            {
                _tarea = value;
                OnPropertyChanged();
            }
        }
        
        public ObservableCollection<Tarea> List
        {
            get { return _list; }
            set
            {
                _list = value;
                OnPropertyChanged("List");
            }
        }



        public Command Add
        {
            get
            {
                return new Command(async () =>
                {
                    _list.Add(new Tarea{Name = this.Tarea, Time = DateTime.Now});
                    OnPropertyChanged("List");
                });
            }
        }




    }
}
