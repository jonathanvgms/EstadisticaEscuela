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

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }

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

        private string _idRol;

        public string IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        public Usuario(string nombre, string contrasenia, string habilitado, string idRol)
        {
            Nombre = nombre;

            Contrasenia = contrasenia;

            Habilitado = habilitado;

            IdRol = idRol;

            Parametros.Add(new Parametro("@unNombre", nombre));

            Parametros.Add(new Parametro("@unaContrasenia", contrasenia));

            Parametros.Add(new Parametro("@unHabilitado", habilitado));

            Parametros.Add(new Parametro("@unIdRol", idRol));

            Tipo = "Usuario";
        }

        public Usuario(string id, string nombre, string contrasenia, string habilitado, string idRol) 
            : this (nombre, contrasenia, habilitado, idRol)
        {
            Id = id;

            Parametros.Add(new Parametro("@unIdUsuario", id));

            Tipo = "Usuario";
        }

        public Usuario(string idUsuario)
        {
            Id = idUsuario;

            Parametros.Add(new Parametro("@unIdUsuario", Id));

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
                        myReader["Contrasenia"].ToString(), myReader["Habilitado"].ToString(), myReader["idRol"].ToString()));
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

