using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using restaurante.Models;

namespace restaurante.DataAccess
{
    public class DBHelper
    {
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=RestauranteBD;Integrated Security=True;TrustServerCertificate=True;";

        // =========================================
        // CLIENTES
        // =========================================
        public List<Cliente> GetClientes()
        {
            var list = new List<Cliente>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Cliente
                            {
                                ID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Telefono = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Email = reader.IsDBNull(3) ? null : reader.GetString(3)
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener clientes: " + ex.Message);
                }
            }
            return list;
        }
        public void InsertCliente(Cliente obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Clientes (Nombre, Telefono, Email) VALUES (@Nombre, @Telefono, @Email)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("@Email", obj.Email);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al insertar cliente: " + ex.Message);
                }
            }
        }
        public DataTable GetClientesTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes", conn);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener la tabla de clientes: " + ex.Message);
                }
            }
            return dt;
        }
        // =========================================
        // MESAS
        // =========================================
        public List<Mesa> GetMesas()
        {
            var list = new List<Mesa>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Mesas", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Mesa
                            {
                                ID = reader.GetInt32(0),
                                Capacidad = reader.GetInt32(1),
                                Ubicacion = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Combinable = reader.GetBoolean(3),
                                Disponible = reader.GetBoolean(4)
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener mesas: " + ex.Message);
                }
            }
            return list;
        }
        public void InsertMesa(Mesa obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Mesas (Capacidad, Ubicacion, Combinable, Disponible) VALUES (@Capacidad, @Ubicacion, @Combinable, @Disponible)", conn);
                    cmd.Parameters.AddWithValue("@Capacidad", obj.Capacidad);
                    cmd.Parameters.AddWithValue("@Ubicacion", obj.Ubicacion);
                    cmd.Parameters.AddWithValue("@Combinable", obj.Combinable);
                    cmd.Parameters.AddWithValue("@Disponible", obj.Disponible);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al insertar mesa: " + ex.Message);
                }
            }
        }
        public void UpdateMesaDisponible(int id, bool disponible)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Mesas SET Disponible = @Disponible WHERE ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@Disponible", disponible);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al actualizar la disponibilidad de la mesa: " + ex.Message);
                }
            }
        }
        public DataTable GetMesasTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Mesas", conn);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener la tabla de mesas: " + ex.Message);
                }
            }
            return dt;
        }
        // =========================================
        // RESERVAS
        // =========================================
        public List<Reserva> GetReservas()
        {
            var reservas = new List<Reserva>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Reservas";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservas.Add(new Reserva
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                ClienteID = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                                MesaID = reader.IsDBNull(reader.GetOrdinal("MesaID")) ? 0 : reader.GetInt32(reader.GetOrdinal("MesaID")),
                                FechaReserva = reader.GetDateTime(reader.GetOrdinal("FechaReserva")),
                                HoraInicio = reader.GetDateTime(reader.GetOrdinal("HoraInicio")),
                                HoraFin = reader.GetDateTime(reader.GetOrdinal("HoraFin")),
                                Estado = reader["Estado"].ToString(),
                                NumeroPersonas = reader.GetInt32(reader.GetOrdinal("NumeroPersonas")),
                                Observaciones = reader["Observaciones"].ToString()
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener reservas: " + ex.Message);
                }
            }
            return reservas;
        }
        public void InsertReserva(Reserva obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Reservas (ClienteID, MesaID, FechaReserva, HoraInicio, HoraFin, Estado, NumeroPersonas, Observaciones) " +
                        "VALUES (@ClienteID, @MesaID, @FechaReserva, @HoraInicio, @HoraFin, @Estado, @NumeroPersonas, @Observaciones)", conn);
                    cmd.Parameters.AddWithValue("@ClienteID", obj.ClienteID);
                    cmd.Parameters.AddWithValue("@MesaID", obj.MesaID);
                    cmd.Parameters.AddWithValue("@FechaReserva", obj.FechaReserva);
                    cmd.Parameters.AddWithValue("@HoraInicio", obj.HoraInicio);
                    cmd.Parameters.AddWithValue("@HoraFin", obj.HoraFin);
                    cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                    cmd.Parameters.AddWithValue("@NumeroPersonas", obj.NumeroPersonas);
                    cmd.Parameters.AddWithValue("@Observaciones", obj.Observaciones);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al insertar reserva: " + ex.Message);
                }
            }
        }
        public void UpdateReservaEstado(int id, string estado)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Reservas SET Estado = @Estado WHERE ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al actualizar el estado de la reserva: " + ex.Message);
                }
            }
        }
        public DataTable GetReservasTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservas", conn);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener la tabla de reservas: " + ex.Message);
                }
            }
            return dt;
        }
        // =========================================
        // MENÚS
        // =========================================
        public List<restaurante.Models.Menu> GetMenus()
        {
            var menus = new List<restaurante.Models.Menu>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Menus", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            menus.Add(new restaurante.Models.Menu
                            {
                                ID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Precio = reader.GetDecimal(3),
                                Disponible = reader.GetBoolean(4)
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener los menús: " + ex.Message);
                }
            }
            return menus;
        }
        public void InsertMenu(restaurante.Models.Menu obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Menus (Nombre, Descripcion, Precio, Disponible) VALUES (@Nombre, @Descripcion, @Precio, @Disponible)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", obj.Precio);
                    cmd.Parameters.AddWithValue("@Disponible", obj.Disponible);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al insertar el menú: " + ex.Message);
                }
            }
        }
        public DataTable GetMenusTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Menus", conn);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener la tabla de menús: " + ex.Message);
                }
            }
            return dt;
        }
        // =========================================
        // PROMOCIONES
        // =========================================
        public List<Promocion> GetPromociones()
        {
            var list = new List<Promocion>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Promociones", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Promocion
                            {
                                ID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Descuento = reader.GetDecimal(3),
                                FechaInicio = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4),
                                FechaFin = reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5)
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener las promociones: " + ex.Message);
                }
            }
            return list;
        }
        public void InsertPromocion(Promocion obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Promociones (Nombre, Descripcion, Descuento, FechaInicio, FechaFin) VALUES (@Nombre, @Descripcion, @Descuento, @FechaInicio, @FechaFin)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@Descuento", obj.Descuento);
                    cmd.Parameters.AddWithValue("@FechaInicio", obj.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", obj.FechaFin);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al insertar promoción: " + ex.Message);
                }
            }
        }
        public DataTable GetPromocionesTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Promociones", conn);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener la tabla de promociones: " + ex.Message);
                }
            }
            return dt;
        }
        // =========================================
        // RECORDATORIOS
        // =========================================
        public void InsertRecordatorio(Recordatorio obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Recordatorios (ReservaID, FechaEnvio, Mensaje, Estado) VALUES (@ReservaID, @FechaEnvio, @Mensaje, @Estado)", conn);
                    cmd.Parameters.AddWithValue("@ReservaID", obj.ReservaID);
                    cmd.Parameters.AddWithValue("@FechaEnvio", obj.FechaEnvio);
                    cmd.Parameters.AddWithValue("@Mensaje", obj.Mensaje);
                    cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al insertar recordatorio: " + ex.Message);
                }
            }
        }
        public DataTable GetRecordatoriosTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Recordatorios", conn);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener la tabla de recordatorios: " + ex.Message);
                }
            }
            return dt;
        }
        // =========================================
        // CELEBRACIONES
        // =========================================
        public List<Celebracion> GetCelebraciones()
        {
            var list = new List<Celebracion>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Celebraciones", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Celebracion
                            {
                                ID = reader.GetInt32(0),
                                ReservaID = reader.GetInt32(1),
                                Tipo = reader.GetString(2),
                                Detalles = reader.IsDBNull(3) ? null : reader.GetString(3)
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener celebraciones: " + ex.Message);
                }
            }
            return list;
        }
        public void InsertCelebracion(Celebracion obj)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Celebraciones (ReservaID, Tipo, Detalles) VALUES (@ReservaID, @Tipo, @Detalles)", conn);
                    cmd.Parameters.AddWithValue("@ReservaID", obj.ReservaID);
                    cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@Detalles", obj.Detalles);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al insertar celebración: " + ex.Message);
                }
            }
        }
        public DataTable GetCelebracionesTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Celebraciones", conn);
                    da.Fill(dt);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al obtener la tabla de celebraciones: " + ex.Message);
                }
            }
            return dt;
        }
        // =========================================
        // GetOrCreateCliente
        // =========================================
        public int GetOrCreateCliente(string nombre, string email, string telefono, string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                    throw;
                }

                // Buscar cliente existente por email
                using (SqlCommand cmd = new SqlCommand("SELECT ID FROM Clientes WHERE Email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }

                // Insertar nuevo cliente y retornar ID
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Clientes (Nombre, Telefono, Email) OUTPUT INSERTED.ID VALUES (@Nombre, @Telefono, @Email)", conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Email", email);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}