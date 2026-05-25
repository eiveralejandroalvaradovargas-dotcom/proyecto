using System;

namespace proyecto1
{
    public class LogicaJuego
    {
        public int PuntajeActual { get; set; }
        public string IdiomaActual { get; set; }
        public int PuntosPorRespuesta { get; set; }
        
        public LogicaJuego()
        {
            PuntajeActual = 0;
            IdiomaActual = "ES";
            PuntosPorRespuesta = 10;
        }
        
        public void ProcesarRespuesta(bool esCorrecta)
        {
            if (esCorrecta)
                PuntajeActual += PuntosPorRespuesta;
            else
                PuntajeActual -= 5;
            
            if (PuntajeActual < 0)
                PuntajeActual = 0;
        }
        
        public void ResetearJuego()
        {
            PuntajeActual = 0;
        }
    }
}