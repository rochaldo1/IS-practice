using IS_practise_7.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_practise_7.ViewModel
{
    internal class MainVM : BaseVM
    {
        private string name = string.Empty;
        private IDataManager dataManager;
        public MainVM(IDataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }
    }
}
