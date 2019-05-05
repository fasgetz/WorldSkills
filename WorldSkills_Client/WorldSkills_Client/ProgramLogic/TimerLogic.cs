using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkills_Client.ProgramLogic
{

    /// <summary>
    /// Клас предоставляет логику работы с таймером
    /// </summary>

    public class TimerLogic
    { 
        // Событие, которое будет вызываться после заданного тика
        public event EventHandler MyEvent;

        private System.Windows.Threading.DispatcherTimer timer; // Ссылка на таймер


        public TimerLogic()
        {
            timer = new System.Windows.Threading.DispatcherTimer(); // таймер
        }


        // Запускаем таймер с интервалом
        public void StartTimer(int time)
        {
            timer.Tick += MyEvent; // Подписываемся на событие из вне
            timer.Interval = new TimeSpan(time); // Тик с интервалом в 1 секунду
            timer.Start(); // Запускает таймер
        }

    }
}
