using System;

namespace proyecto1
{
	public class PuntuacionJugador
	{
		public int IdUsuario {get;set;}
		public int IdModulo {get;set;}
		public int Puntos {get;set;}
		
		public PuntuacionJugador() {}
		
		public PuntuacionJugador(int idUsuario, int idModulo, int puntos)
		{
			IdUsuario = idUsuario;
			IdModulo = idModulo;
			Puntos = puntos;
		}
	}
	
}
