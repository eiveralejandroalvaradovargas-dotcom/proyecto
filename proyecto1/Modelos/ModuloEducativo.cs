using System;

namespace proyecto1
{
	public class ModuloEducativo
	{
		public int Id {get;set;}
		public string Nombre {get;set;}
		public string Descripcion {get;set;}
		public ModuloEducativo(int id, string nombre, string descripcion)
		{
			Id = id;
			Nombre = nombre;
			Descripcion = descripcion;
		}
	}
}
