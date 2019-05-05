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
using WorldSkills_Client.ProgramLogic;

namespace WorldSkills_Client.View.Common
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            lbdate.Content = DateTime.Now.ToString("D");
            App.Current.MainWindow.Title = "Marathon Skills 2019 - Главное окно";
        }


        #region Методы

        // Событие на клик кнопки Авторизация, которая перейдет на страницу авторизации
        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(locator.AuthPage);
            //NavigationService.Navigate(new Uri("View/Common/AuthorizationPage.xaml", UriKind.Relative));
        }

        // Событие на клик кнопки Я хочу стать спонсором, которая перейдет на страницу спонсирования
        private void Sponsored_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(locator.GetSponsoredPages());
            //NavigationService.Navigate(new Uri("View/Common/SponsoredPage.xaml", UriKind.Relative));
        }

        #endregion
    }
}
