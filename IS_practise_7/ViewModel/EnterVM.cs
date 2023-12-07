﻿using IS_practise_7.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IS_practise_7.ViewModel.DataManager;
using IS_practise_7.View;
using System.Windows.Input;
using IS_practise_7.ViewModel.Commands;

namespace IS_practise_7.ViewModel
{
    public class EnterVM : BaseVM
    {
        string login = string.Empty;
        string password = string.Empty;
        private IDataManager dataManager;

        public event Action? LoginSucces;
        public event Action<string>? LoginFailed;

        public EnterVM(IDataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public string Login
        {
            get => login;
            set => Set(ref login, value);
        }

        public string Password
        {
            get => password;
            set =>Set(ref password, value);
        }

        private void StartSignUp()
        {
            if(dataManager.TryAuthorization(Login, Password))
            {
                LoginSucces?.Invoke();
            }
            else
            {
                LoginFailed?.Invoke("Неверный ввод или такого пользователя нет!");
            }
        }

        public ICommand StartSignUpCommand
        {
            get
            {
                return new Command(() =>
                {
                    StartSignUp();
                });
            }
        }
    }
}
