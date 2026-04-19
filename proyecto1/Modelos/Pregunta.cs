using System;
using System.Collections.Generic;

namespace proyecto1
{

	public class Pregunta
	{
		public int Id {get;set;}
		public int IdModulo {get;set;}
		public string TextoEs {get;set;}
		public string TextoEn {get;set;}
		public string ImagenRuta {get;set;}
		
		public List<opcion> opciones {get;set;}
			
		public Pregunta()
		{
			opciones = new List<opcion>();
		}
		
		public Pregunta(int id, int idModulo, string textoEs, string textoEn, string imagenRuta)
		{
			Id = id;
			IdModulo = idModulo;
			TextoEs = textoEs;
			TextoEn = textoEn;
			ImagenRuta = imagenRuta;
			opciones = new List<opcion>();
		}
	}
}
