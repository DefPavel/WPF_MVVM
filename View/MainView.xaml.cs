
using System;
using System.Windows.Controls;


namespace WPF_MVVM
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            APIHelpers aPI = new APIHelpers();
            var hostel = aPI.GetHostelNew("saint","kek", "/hostel/GetHostel.json");
            tree.ItemsSource = hostel;
        }
    }
}
