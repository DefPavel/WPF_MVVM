using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WPF_MVVM
{
    //Здесь модель чисто для TreeView
    //Возвращая его коллекцию
   public class Hostel
    {
        public Hostel()
        {
            this.ARRAY_HOSTEL = new ObservableCollection<itemHostel>();
        }
        public ObservableCollection<itemHostel> ARRAY_HOSTEL { get; set; }
    }
    public class itemHostel
    {

        public itemHostel()
        {
            this.Section = new ObservableCollection<itemSection>();
        }
        public int idHostel { get; set; }
        public string Hostel { get; set; }

        public ObservableCollection<itemSection> Section { get; set; }
    }
    public class itemSection
    {
        public itemSection()
        {
            this.Room = new ObservableCollection<itemRoom>();
        }
        public int idSection { get; set; }

        public string SectionName { get; set; }

        public ObservableCollection<itemRoom> Room { get; set; }
    }
    public class itemRoom
    {
        public int idRoom { get; set; }
        public string Number_Room { get; set; }
    }
}
