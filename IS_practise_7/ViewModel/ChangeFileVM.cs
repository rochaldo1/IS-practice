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
    public class ChangeFileVM : BaseVM
    {
        private IDataManager dataManager;
        private string path = string.Empty;
        private string text = string.Empty;
        public event Action? FileSaver;
        public ChangeFileVM(IDataManager dataManager,string path, string text) 
        {
            this.dataManager = dataManager;
            this.path = path;
            this.text = text;
        }
        public string Text
        {
            get => text;
            set => Set(ref text, value);
        }

        public void ChangeFileAndSave()
        {
            dataManager._concreteUser.ChangeFile(path, Text);
            FileSaver?.Invoke();
        }

        public ICommand SaveThisFile
        {
            get
            {
                return new Command(() =>
                {
                    ChangeFileAndSave();
                });
            }
        }

    }
}
