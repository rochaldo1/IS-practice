﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_practise_7.Model.Possibilities
{
    public class CantChangeFile : IChangeFile
    {
        public string ChangeFile(string path, string text) => "У вас нет доступа к изменению файлов!";
    }
}
