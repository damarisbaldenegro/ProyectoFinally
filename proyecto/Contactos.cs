
using System;

namespace Agenda
{
	/// <summary>
	/// Description of Contactos.
	/// </summary>
	public class Contactos
	{
		public int id {get; set;}
		public string nombre {get; set;}
		public string domicilio {get; set;}
		public string colonia {get; set;}
		public string ciudad {get; set;}
		public string email {get; set;}
		public string tel {get; set;}
		public string Celular {get; set;}
		
		
		public Contactos()
		{
		}
		
		public Contactos (int pId, string pnombre, string pdomicilio, string pcolonia, string pciudad, string pemail, string ptelefono, string pcelular)
		{
			this.id = pId;
			this.nombre = pnombre;
			this.domicilio = pdomicilio;
			this.colonia = pcolonia;
			this.ciudad = pciudad;
			this.email = pemail;
			this.tel = ptelefono;
			this.Celular = pcelular;
		}
		
	}
}
