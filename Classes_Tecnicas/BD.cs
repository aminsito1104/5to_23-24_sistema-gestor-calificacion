﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_calificaciones.Classes_Tecnicas
{
    public class BD
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBregistro;Data Source=DESKTOP-0SL8C9J\MSSQLSERVER01");

            conexion.Open();

            return conexion;
        }
    }
}
