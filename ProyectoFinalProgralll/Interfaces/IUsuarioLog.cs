﻿using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgralll.Interfaces
{
    public interface IUsuarioLog
    {
        void RegistroLog(LogUsuarios log);
        DataSet ObtenerLogs();
    }
}
