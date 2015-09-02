using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Usuario :Objeto
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombreUsuario;

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }

        }

        private string _contrasenia;

        public string Contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }

        private string _habilitado;

        public string Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public Usuario(string nombre, string contrasenia, string habilitado)
        {
            NombreUsuario = nombre;

            Contrasenia = contrasenia;

            Habilitado = habilitado;

            Parametros.Add(new Parametro("@unNombre", nombre));

            Parametros.Add(new Parametro("@unaContrasenia", contrasenia));

            Parametros.Add(new Parametro("@unHabilitado", habilitado));

            Tipo = "Usuario";
        }

        public Usuario(string id, string nombreUsuario, string contrasenia, string habilitado)
            : this(nombreUsuario, contrasenia, habilitado)
        {
            Id = id;

            Parametros.Add(new Parametro("@unIdUsuario", Id));

            Tipo = "Usuario";
        }

        public Usuario(string idUsuario)
        {
            _id = idUsuario;

            Parametros.Add(new Parametro("@unIdUsuario", _id));

            Tipo = "Usuario";
        }

        public static List<Usuario> Select()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string query = "select * from usuario";

            usuarios = Query(query, usuarios);

            return usuarios;
        }

        public static List<Usuario> Select(string where)
        {
            List<Usuario> usuarios = new List<Usuario>();

            string query = "select * from usuario" + where;

            usuarios = Query(query, usuarios);

            return usuarios;
        }

        private static List<Usuario> Query(string query, List<Usuario> usuarios)
        {
            MySqlDataReader myReader = null;

            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand command = new MySqlCommand(query, connectionLive);

            try
            {
                connectionLive.Open();

                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    usuarios.Add(new Usuario(myReader["Id"].ToString(), myReader["Nombre"].ToString(),
                        myReader["Contrasenia"].ToString(), myReader["Habilitado"].ToString()));
                }

                myReader.Dispose();

                connectionLive.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return usuarios;

            }
        }
    }

