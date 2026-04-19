using System;

namespace proyecto1
{

	public class opcion
	{
		public int Id {get;set;}
		public string TextoEs {get;set;}
		public string TextoEn {get;set;}
		public bool EsCorrecta {get;set;}
		
		public opcion(int id, string textoEs, string textoEn, bool esCorrecta)
		{
			Id = id;
			TextoEs = textoEs;
			TextoEn = textoEn;
			EsCorrecta = esCorrecta;
		}
	}
}
