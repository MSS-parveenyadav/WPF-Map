using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mapApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myMap.Focus();

            //AddLocation();
            
        }

        private void AddLocation(double lat,double lng)
        {
            Dispatcher.Invoke(() =>
            {
                try
                {
                    Location currentLocation = new Microsoft.Maps.MapControl.WPF.Location(lat, lng);

                    Pushpin currentPushpin = new Pushpin();
                    currentPushpin.Location = currentLocation;
                    currentPushpin.ToolTip = "sdfsdf";
                    myMap.Children.Add(currentPushpin);

                   
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            });
        }


        public NameValueCollection GetCollection()
        {


            var collection = new NameValueCollection();


        }
    }
}
