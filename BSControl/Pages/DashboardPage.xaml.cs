using BSControl.UserControls;
using System;
using System.Collections.Generic;
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

namespace BSControl.Pages
{
    /// <summary>
    /// Interaction logic for DashboardPage.xaml
    /// </summary>
    public partial class DashboardPage : Page
    {
        public DashboardPage()
        {
            InitializeComponent();
            PageTitleUserControl pageTitleUserControl = new PageTitleUserControl();
            pageTitleUserControl.PageTitle.Content = "Dashboard";
            UserControls.Children.Add(pageTitleUserControl);

            AnalogCards.Children.Add(new AnalogCardUserControl { txtCardName = "Meter 1", txtCardValue = "76.4" });
        }
    }
}
