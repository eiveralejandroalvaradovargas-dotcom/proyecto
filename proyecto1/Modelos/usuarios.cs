using System;

namespace proyecto1
{
	public class Usuarios
	{ 
		public int Id {get;set;}
		public string Username {get;set;}
		public string Password {get;set;}
		public string Rol {get;set;}
		
		public Usuarios(int Id, string Username, string Password, string Rol)
		{
			this.Id = Id;
			this.Username = Username;
			this.Password = Password;
			this.Rol = Rol; // Admin || Jugador
		}
	}
}
