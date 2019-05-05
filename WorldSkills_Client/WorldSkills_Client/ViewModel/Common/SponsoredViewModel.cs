using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using WorldSkills_Client.Model.DB;
using WorldSkills_Client.ProgramLogic;
using WorldSkills_Client.ViewModel.FromMVVM;

namespace WorldSkills_Client.View.Common
{
    class SponsoredViewModel : BaseVM
    {
        #region Свойства

        private ObservableCollection<Runner> _RunnersList;
        public ObservableCollection<Runner> RunnersList
        {
            get => _RunnersList;
            set
            {
                _RunnersList = value;
                OnPropertyChanged("RunnersList");
            }
        }

        private string _sum;
        public string sum
        {
            get => _sum;
            set
            {
                _sum = value;
                OnPropertyChanged("sum");
            }
        }
        #endregion

        #region Команды

        public DelegateCommand MyCommand
        {
            get
            {
                return new DelegateCommand(obj =>
                {
                    MessageBox.Show("kek");
                });
            }
        }

        #endregion

        public SponsoredViewModel()
        {
            using (MyDB db = new MyDB())
            {
                RunnersList = new ObservableCollection<Runner>(db.Runner);
            }
        }

    }
}
