﻿using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{    
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}
