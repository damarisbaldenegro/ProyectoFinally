using System;
using MySql.Data.MySqlClient;

namespace Agenda
{
	
	public class Conectar
	{
		public static MySqlConnection ObtenerConexion()
		{
			MySqlConnection conecta= new MySqlConnection("server = 127.0.0.1; database= agenda; Uid=root; Pwd =damaris;");
			conecta.Open();
			return conecta;
		}
	}
}
