using System;

namespace proyecto1
{
    public class LogicaJuego
    {
        public int PuntajeActual { get; set; }
        public string IdiomaActual { get; set; } // "ES" o "EN"
        
        public LogicaJuego()
        {
            PuntajeActual = 0;
            IdiomaActual = "ES";
        }
        
        public void ProcesarRespuesta(bool esCorrecta)
        {
            if (esCorrecta)
                PuntajeActual += 10;
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