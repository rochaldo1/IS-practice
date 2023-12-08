using IS_practise_7.ViewModel.Commands;
using IS_practise_7.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IS_practise_7.ViewModel
{
    public class MainVM : BaseVM
    {
        private string name = string.Empty;
        
        private IDataManager dataManager;

        public event Action<string>? FileReader;
        public MainVM(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            Name = dataManager._concreteUser.Login;
        }

        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        private void Read_First_File()
        {
            FileReader.Invoke(dataManager._concreteUser.ReadFile(dataManager._concreteUser.RoutesToRead[0]));
        }

        private void Read_Second_File()
        {
            FileReader.Invoke(dataManager._concreteUser.ReadFile(dataManager._concreteUser.RoutesToRead[1]));
        }
        private void Read_Third_File()
        {
            FileReader.Invoke(dataManager._concreteUser.ReadFile(dataManager._concreteUser.RoutesToRead[2]));
        }
        private void Read_Fourth_File()
        {
            FileReader.Invoke(dataManager._concreteUser.ReadFile(dataManager._concreteUser.RoutesToRead[3]));
        }
        private void Read_Fifth_File()
        {
            FileReader.Invoke(dataManager._concreteUser.ReadFile(dataManager._concreteUser.RoutesToRead[4]));
        }
        public ICommand ReadFirstFileCommand
        {
            get
            {
                return new Command(() =>
                {
                    Read_First_File();
                });
            }
        }

        public ICommand ReadSecondFileCommand
        {
            get
            {
                return new Command(() =>
                {
                    Read_Second_File();
                });
            }
        }

        public ICommand ReadThirdFileCommand
        {
            get
            {
                return new Command(() =>
                {
                    Read_Third_File();
                });
            }
        }

        public ICommand ReadFourthFileCommand
        {
            get
            {
                return new Command(() =>
                {
                    Read_Fourth_File();
                });
            }
        }

        public ICommand ReadFifthFileCommand
        {
            get
            {
                return new Command(() =>
                {
                    Read_Fifth_File();
                });
            }
        }
    }
}
