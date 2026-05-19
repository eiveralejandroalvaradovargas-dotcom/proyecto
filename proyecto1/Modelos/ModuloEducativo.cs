using System;

namespace proyecto1
{
	public class ModuloEducativo
	{
		public int Id {get;set;}
		public string NombreEs {get;set;}
		public string NombreEn {get;set;}
		public string Descripcion {get;set;}
		
		public ModuloEducativo(int id, string nombreEs, string nombreEn, string descripcion)
		{
			Id = id;
			NombreEs = nombreEs;
			NombreEn = nombreEn;
			Descripcion = descripcion;
		}
	}
}
