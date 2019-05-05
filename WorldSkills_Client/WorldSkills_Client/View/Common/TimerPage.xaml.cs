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
    /// Логика взаимодействия для TimerPage.xaml
    /// </summary>
    public partial class TimerPage : Page
    {

        #region Свойства
        
        DateTime endDate = new DateTime(2019, 10, 19); // Финальная дата (То есть дата начала марафона)

        #endregion

        public TimerPage()
        {
            InitializeComponent();

            StartTime(); // Запускаем таймер
        }


        // Метод, который запускает таймер
        private void StartTime()
        {
            var timer = new TimerLogic();

            timer.MyEvent += new EventHandler(timerTick); // Подписываемся на метод
            timer.StartTimer(1000); // Задаем интервал в 1 секунду
        }
        

        // Метод, который работает с таймером
        private void timerTick(object sender, EventArgs e)
        {
            var date = endDate - DateTime.Now; // Вычитаем дату начала и текущую и выводим разниу

            // Выводим разницу
            lbdate.Content = $"{date.Days} дней {date.Hours} часов {date.Minutes} минут {date.Seconds} секунд до начала марафона";
        }
    }
}
