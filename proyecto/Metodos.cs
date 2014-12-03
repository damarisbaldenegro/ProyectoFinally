
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Agenda
{
	
	public class Metodos
	{
		public static int Agregar(Contactos Contactos)
		{
			int retorno =0;
			
			MySqlCommand comando = new MySqlCommand(string.Format("insert into contactos(nombre, domicilio,  email, Tel, Celular)values('{0}','{1}','{2}','{3}','{4}') ",
			                                                      Contactos.nombre, Contactos.domicilio,  Contactos.email, Contactos.tel, Contactos.Celular),Conectar.ObtenerConexion());
			retorno = comando.ExecuteNonQuery();
			return retorno;
			
		}
       
		public static List<Contactos> Buscar(string nombre)
		{
			List<Contactos> lista = new List<Contactos>();
			MySqlCommand comando = new MySqlCommand(string.Format("SELECT id, nombre, domicilio,  email, tel, Celular from contactos where nombre LIKE '%{0}%' ", nombre), Conectar.ObtenerConexion());
			MySqlDataReader _reader=comando.ExecuteReader();
			while (_reader.Read())
			{
				Contactos contactos = new Contactos();
				
				contactos.id=_reader.GetInt32(0);
				contactos.nombre=_reader.GetString(1);
				contactos.domicilio=_reader.GetString(2);
				contactos.colonia=_reader.GetString(3);
				contactos.ciudad=_reader.GetString(4);
				contactos.email=_reader.GetString(5);
				contactos.tel=_reader.GetString(6);
				contactos.Celular=_reader.GetString(7);
				
				lista.Add(contactos);
				
				
				
			}
			
			return lista;
		
		}

		public static Contactos ObtenerContactos(int Id)
		{
			Contactos Contactos = new Contactos();
			MySqlConnection conexion = Conectar.ObtenerConexion();
			MySqlCommand comando = new MySqlCommand(string.Format("select id, nombre, domicilio,  email, tel, Celular from contactos where id= '{0}' ",Id), Conectar.ObtenerConexion());
			MySqlDataReader leer =comando.ExecuteReader();
			while (leer.Read())
			{
				Contactos.id=leer.GetInt32(0);
				Contactos.nombre=leer.GetString(1);
				Contactos.domicilio=leer.GetString(2);
				Contactos.email=leer.GetString(5);
				Contactos.tel=leer.GetString(6);
				Contactos.Celular=leer.GetString(7);
			}
			
			conexion.Close();
			return Contactos;
			
		}
		
		
		
		public static int Editar(Contactos Contactos)
		{
			int resultado=0;
			
			MySqlConnection conexion = Conectar.ObtenerConexion();
			MySqlCommand comando = new MySqlCommand(string.Format("update contactos set nombre ='{0}', domicilio ='{1}', email='{2}', tel= '{3}', Celular= '{4}' where id ='{7}'",Contactos.nombre, Contactos.domicilio,  Contactos.email, Contactos.tel, Contactos.Celular, Contactos.id), conexion);
			resultado = comando.ExecuteNonQuery();
			conexion.Close();
			return resultado;
			
		}
		
		
		public static int Eliminar(int pId)
		{
			int resultado =0;
			MySqlConnection conexion = Conectar.ObtenerConexion();
			MySqlCommand comando = new MySqlCommand(string.Format("delete from contactos where id={0}",pId),conexion);
			resultado = comando.ExecuteNonQuery();
			return resultado;
		}
		
		
	}
}
