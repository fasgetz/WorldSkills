using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
using WorldSkills_Client.Model.DB;
using WorldSkills_Client.ProgramLogic;

namespace WorldSkills_Client.View.Common
{
    /// <summary>
    /// Логика взаимодействия для SponsoredPage.xaml
    /// </summary>
    public partial class SponsoredPage : Page
    {
        private SponsoredViewModel vm;

        public SponsoredPage()
        {
            InitializeComponent();

            App.Current.MainWindow.Title = "Marathon Skills 2019 - Спонсирование бегуна";

            DataContext = new SponsoredViewModel();
        }


        //private Task<List<Runner>> GetRunners()
        //{
        //    return Task<List<Runner>>.Factory.StartNew(GetRunnersList);
        //}

        //private List<Runner> GetRunnersList()
        //{
        //    using (MyDB db = new MyDB())
        //    {
        //        return db.Runner.Include(p => p.User).ToListAsync().Result;
        //    }             
        //}

        //// Асинхронный метод загрузки данных
        //private async void load()
        //{
        //    // Если список пустой, то прогрузи
        //    if (cbrunners.ItemsSource == null)
        //    {
        //        //list = await GetRunners();
        //        cbrunners.ItemsSource = await GetRunners();
        //    }
        //}

        //List<Runner> list;

        #region События

        // Событие на клик кнопки Назад, которая перейдет в главное меню
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {            
            NavigationService.Navigate(locator.GetMain());
        }

        // Событие на клик кнопки Назад, которая перейдет в главное меню
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            string s = lbsum.Content.ToString();
            s = s.Remove(0, 1);
            int sum = Convert.ToInt32(s) - Convert.ToInt32(tbval.Text); // Получаем сумму

            // Если сумма <= 9999, то прибавь
            if (sum >= 1)
                lbsum.Content = "$" + sum.ToString();
        }

        // Событие на клик кнопки Назад, которая перейдет в главное меню
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            string s = lbsum.Content.ToString();
            s = s.Remove(0, 1);
            int sum = Convert.ToInt32(s) + Convert.ToInt32(tbval.Text); // Получаем сумму

            // Если сумма <= 9999, то прибавь
            if (sum <= 9999)
                lbsum.Content = "$" + sum.ToString();
        }

        // Событие на текстовые поля, которые позволяют вводить только цифры
        private void Tbsum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!int.TryParse(e.Text, out val))
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        #endregion

        // Событие на изменение в ComboBoxe's выбора бегунов
        private void Cbrunners_Selected(object sender, RoutedEventArgs e)
        {
            //cbrunners.ItemsSource = null;
            //var a = (Runner)cbrunners.SelectedItem;
            //MessageBox.Show(a.Registration.Count().ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
