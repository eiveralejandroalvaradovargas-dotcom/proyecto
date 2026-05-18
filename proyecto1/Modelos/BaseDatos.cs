using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace proyecto1
{
	public static class BaseDatos
	{
		private static string cadenaconexion = "Server=localhost;Database=JuegoEducativo;Uid=root;Pwd='';";
		
		//USUARIOS//
		
		public static List<Usuarios> ObtenerUsuarios()
		{
			List<Usuarios> lista = new List<Usuarios>();
			using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				conexion.Open();
				string datos = "SELECT id, nombre, clave, rol FROM USUARIO";
				MySqlCommand cmd = new MySqlCommand(datos, conexion);
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while(reader.Read())
					{
						Usuarios u = new Usuarios(
							reader.GetInt32("id"),
							reader.GetString("nombre"),
							reader.GetString("clave"),
							reader.GetString("rol"));
						lista.Add(u);
					}
				}
			}return lista;
		}
		
		public static void AgregarUsuario(Usuarios usuario)
		{
			using(MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				conexion.Open();
				string datos = "INSERT INTO USUARIO (nombre ,clave ,rol) VALUES (@nombre ,@clave ,@rol)";
				MySqlCommand cmd = new MySqlCommand(datos, conexion);
				cmd.Parameters.AddWithValue("@nombre", usuario.Username);
				cmd.Parameters.AddWithValue("@clave", usuario.Password);
				cmd.Parameters.AddWithValue("@rol", usuario.Rol);
				cmd.ExecuteNonQuery();
			}
		}
		
		public static void ActualizarUsuario(Usuarios usuario)
		{
			using(MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				conexion.Open();
				string datos = "UPDATE USUARIO SET nombre = @nombre, clave = @clave, rol = @rol WHERE id = @id";
				MySqlCommand cmd = new MySqlCommand(datos, conexion);
				cmd.Parameters.AddWithValue("@nombre", usuario.Username);
				cmd.Parameters.AddWithValue("@clave", usuario.Password);
				cmd.Parameters.AddWithValue("@rol", usuario.Rol);
				cmd.Parameters.AddWithValue("@id", usuario.Id);
				cmd.ExecuteNonQuery();
			}
		}
		
		public static void EliminarUsuario(int id)
		{
			using(MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				conexion.Open();
				string datos = "DELETE FROM USUARIO WHERE id = @id";
				MySqlCommand cmd = new MySqlCommand(datos, conexion);
				cmd.Parameters.AddWithValue("@id", id);
				cmd.ExecuteNonQuery();
			}
		}
		
		//MODULOS//
		
		public static List<ModuloEducativo> ObtenerModulos()
		{
			List<ModuloEducativo> lista = new List<ModuloEducativo>();
			using(MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				conexion.Open();
				string datos = "SELECT id, nombre, descripcion FROM MODULO";
				MySqlCommand cmd = new MySqlCommand(datos, conexion);
				using(MySqlDataReader reader = cmd.ExecuteReader())
				{
					while(reader.Read())
					{
					ModuloEducativo m = new ModuloEducativo(
						reader.GetInt32("id"),
						reader.GetString("nombre"),
						reader.GetString("descripcion"));
					lista.Add(m);
					}
				}
			}return lista;
		}
		
		public static void AgregarModulo(ModuloEducativo modulo)
		{
			using(MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				conexion.Open();
				string datos = "INSERT INTO MODULO (nombre, descripcion) VALUES (@nombre, @descripcion)";
				MySqlCommand cmd = new MySqlCommand(datos, conexion);
				cmd.Parameters.AddWithValue("@nombre", modulo.Nombre);
				cmd.Parameters.AddWithValue("@descripcion", modulo.Descripcion);
				cmd.ExecuteNonQuery();
			}
		}
		
		public static void ActualizarModulo(ModuloEducativo modulo)
		{
			using(MySqlConnection conexion = new MySqlConnection(cadenaconexion))
			{
				conexion.Open();
				string datos = "UPDATE MODULO SET nombre = @nombre, descripcion = @descripcion WHERE id = @id";
				MySqlCommand cmd = new MySqlCommand(datos, conexion);
				cmd.Parameters.AddWithValue("@nombre", modulo.Nombre);
				cmd.Parameters.AddWithValue("@descripcion", modulo.Descripcion);
				cmd.Parameters.AddWithValue("@id", modulo.Id);
				cmd.ExecuteNonQuery();
			}
		}
		
		 public static void EliminarModulo(int id)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = "DELETE FROM MODULO WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
		 
		 //PREGUNTAS//
		 
		 public static List<Pregunta> ObtenerPreguntas()
        {
            List<Pregunta> lista = new List<Pregunta>();
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = "SELECT id, idModulo, preguntaEs, preguntaEn, imagenRuta FROM PREGUNTA";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pregunta p = new Pregunta(
                            reader.GetInt32("id"),
                            reader.GetInt32("idModulo"),
                            reader.GetString("preguntaEs"),
                            reader.GetString("preguntaEn"),
                            reader.GetString("imagenRuta")
                        );
                        lista.Add(p);
                    }
                }
            }
            foreach (Pregunta p in lista)
            {
                p.opciones = ObtenerOpcionesPorPregunta(p.Id);
            }
            return lista;
        }
		 
		 public static void AgregarPregunta(Pregunta pregunta)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = @"INSERT INTO PREGUNTA (idModulo, preguntaEs, preguntaEn, imagenRuta) 
                               VALUES (@idModulo, @preguntaEs, @preguntaEn, @imagenRuta)";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                cmd.Parameters.AddWithValue("@idModulo", pregunta.IdModulo);
                cmd.Parameters.AddWithValue("@preguntaEs", pregunta.TextoEs);
                cmd.Parameters.AddWithValue("@preguntaEn", pregunta.TextoEn);
                cmd.Parameters.AddWithValue("@imagenRuta", pregunta.ImagenRuta ?? "");
                cmd.ExecuteNonQuery();
                long newId = cmd.LastInsertedId;
                pregunta.Id = (int)newId;

                foreach (opcion op in pregunta.opciones)
                {
                    AgregarOpcion(op, pregunta.Id);
                }
            }
        }
		 
		 public static void ActualizarPregunta(Pregunta pregunta)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = "UPDATE PREGUNTA SET idModulo = @idModulo, preguntaEs = @preguntaEs, preguntaEn = @preguntaEn, imagenRuta = @imagenRuta WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                cmd.Parameters.AddWithValue("@idModulo", pregunta.IdModulo);
                cmd.Parameters.AddWithValue("@preguntaEs", pregunta.TextoEs);
                cmd.Parameters.AddWithValue("@preguntaEn", pregunta.TextoEn);
                cmd.Parameters.AddWithValue("@imagenRuta", pregunta.ImagenRuta ?? "");
                cmd.Parameters.AddWithValue("@id", pregunta.Id);
                cmd.ExecuteNonQuery();

                EliminarOpcionesPorPregunta(pregunta.Id);
                foreach (opcion op in pregunta.opciones)
                {
                    AgregarOpcion(op, pregunta.Id);
                }
            }
        }
		 
		 public static void EliminarPregunta(int id)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = "DELETE FROM PREGUNTA WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
		 
		 //OPCIONES//
		 
		  private static List<opcion> ObtenerOpcionesPorPregunta(int idPregunta)
        {
            List<opcion> lista = new List<opcion>();
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = "SELECT id, idPregunta, textoES, textoEn, esCorrecta FROM OPCION WHERE idPregunta = @idPregunta";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                cmd.Parameters.AddWithValue("@idPregunta", idPregunta);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        opcion o = new opcion(
                            reader.GetInt32("id"),
                            reader.GetInt32("idPregunta"),
                            reader.GetString("textoES"),
                            reader.GetString("textoEn"),
                            reader.GetBoolean("esCorrecta")
                        );
                        lista.Add(o);
                    }
                }
            }
            return lista;
        }
		  
		  private static void AgregarOpcion(opcion opcion, int idPregunta)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = "INSERT INTO OPCION (idPregunta, textoES, textoEn, esCorrecta) VALUES (@idPregunta, @textoES, @textoEn, @esCorrecta)";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                cmd.Parameters.AddWithValue("@idPregunta", idPregunta);
                cmd.Parameters.AddWithValue("@textoES", opcion.TextoEs);
                cmd.Parameters.AddWithValue("@textoEn", opcion.TextoEn);
                cmd.Parameters.AddWithValue("@esCorrecta", opcion.EsCorrecta);
                cmd.ExecuteNonQuery();
            }
        }
		  
		  private static void EliminarOpcionesPorPregunta(int idPregunta)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = "DELETE FROM OPCION WHERE idPregunta = @idPregunta";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                cmd.Parameters.AddWithValue("@idPregunta", idPregunta);
                cmd.ExecuteNonQuery();
            }
        }
		  
		  //PUNTUACIONES//
		  
		  public static List<PuntuacionJugador> ObtenerPuntuaciones()
        {
            List<PuntuacionJugador> lista = new List<PuntuacionJugador>();
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = "SELECT idUsuario, idModulo, puntos FROM PUNTUACION";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PuntuacionJugador p = new PuntuacionJugador(
                            reader.GetInt32("idUsuario"),
                            reader.GetInt32("idModulo"),
                            reader.GetInt32("puntos")
                        );
                        lista.Add(p);
                    }
                }
            }
            return lista;
        }
		  
		  public static void GuardarPuntuacion(int idUsuario, int idModulo, int puntos)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string checkSql = "SELECT id FROM PUNTUACION WHERE idUsuario = @idUsuario AND idModulo = @idModulo";
                MySqlCommand checkCmd = new MySqlCommand(checkSql, conexion);
                checkCmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                checkCmd.Parameters.AddWithValue("@idModulo", idModulo);
                object result = checkCmd.ExecuteScalar();
                if (result != null)
                {
                    string updateSql = "UPDATE PUNTUACION SET puntos = @puntos WHERE idUsuario = @idUsuario AND idModulo = @idModulo AND puntos < @puntos";
                    MySqlCommand updateCmd = new MySqlCommand(updateSql, conexion);
                    updateCmd.Parameters.AddWithValue("@puntos", puntos);
                    updateCmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    updateCmd.Parameters.AddWithValue("@idModulo", idModulo);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    string insertSql = "INSERT INTO PUNTUACION (idUsuario, idModulo, puntos) VALUES (@idUsuario, @idModulo, @puntos)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conexion);
                    insertCmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    insertCmd.Parameters.AddWithValue("@idModulo", idModulo);
                    insertCmd.Parameters.AddWithValue("@puntos", puntos);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }
		  
		  public static int ObtenerPuntuacion(int idUsuario, int idModulo)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaconexion))
            {
                conexion.Open();
                string datos = "SELECT puntos FROM PUNTUACION WHERE idUsuario = @idUsuario AND idModulo = @idModulo";
                MySqlCommand cmd = new MySqlCommand(datos, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@idModulo", idModulo);
                object result = cmd.ExecuteScalar();
                if (result != null)
                    return Convert.ToInt32(result);
                else
                    return 0;
            }
        }
	}
}
