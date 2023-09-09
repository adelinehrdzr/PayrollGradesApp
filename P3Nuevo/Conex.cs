using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace P3Nuevo
{
    internal class Conex
    {
        public static SqlConnection Conectar()
        {
            SqlConnection Conex = new
             SqlConnection("SERVER=LAPTOP-M2CP34D4\\SQLEXPRESS;DATABASE=P3;Integrated Security=true");
            Conex.Open();
            return Conex;

        }

    }
}
