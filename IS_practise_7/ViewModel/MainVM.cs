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
    internal class MainVM : BaseVM
    {
        private string name = string.Empty;
        private IDataManager dataManager;

        public event Action<string, string> FileReader;
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
            FileReader.Invoke(dataManager._concreteUser.RoutesToRead[0], dataManager._concreteUser.ReadFile(dataManager._concreteUser.RoutesToRead[0]));
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
    }
}
