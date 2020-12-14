using Caliburn.Micro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_MVVM
{
    //Главный USerControl 
   public class MainViewModel : Screen
    {
        private readonly IAPIHelpers _aPIHelpers;
        //private Hostel _items;
        // private Hostel _selectedItem;
        private readonly CollectionViewSource usersCollection;
        public MainViewModel(IAPIHelpers aPIHelper)
        {
            _aPIHelpers = aPIHelper;

            var hh = _aPIHelpers.GetHostelNew("saint", "kek", "/hostel/GetHostel.json");
             ObservableCollection<Hostel> host = new ObservableCollection<Hostel>(hh);

            


            usersCollection = new CollectionViewSource();
            usersCollection.Source = host;

            //Выгрузка данных об всех общежитиях
            //itemsHostel = 

        }
        /* public ICollectionView SourceCollection
         {
             get
             {
                 return this.usersCollection.View;
             }
         }*/
       

        /*  public Hostel selectedItem
          {
              get { return _selectedItem; }
              set 
              {
                  _selectedItem = value;
                  NotifyOfPropertyChange(() => _selectedItem);
              }
          }

          public Hostel itemsHostel
          {
              get { return _items; }
              set { _items = value; }
          }*/


    }
}
