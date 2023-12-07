using IS_practise_7.Data.Users;
using System.Configuration;
using System.Data;
using System.Windows;
using IS_practise_7.ViewModel.DataManager;

using IS_practise_7.View;

namespace IS_practise_7
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IDataManager _dataManager;
        private SerializeUsers serializeUsers;

        public App() : base()
        {
            string path = ConfigurationManager.AppSettings["Userspath"] ?? string.Empty;
            serializeUsers = new SerializeUsers(path);
            _dataManager = DataManager.Instance(serializeUsers);
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            await _dataManager.LoadAllUsersAsync();
            //_dataManager.LoadAllUsersAsync();

            EnterWindow enterWindow = new EnterWindow(_dataManager);
            enterWindow.Show();
        }

    }

}
