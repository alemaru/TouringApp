using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using TouringApp.Models.TO;

namespace TouringApp.Models.DAO
{
   
    public class UsuarioDAO
    {
        /// <summary>
        /// Implementacion del patron Singleton a la clase DAO
        /// </summary>
        private static UsuarioDAO instance = null;
        protected UsuarioDAO() { }
        public static UsuarioDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UsuarioDAO();
                return instance;
            }
        }

        /// <summary>
        /// Implementacion de las funciones
        /// </summary>
        private TouringDBEntities db = new TouringDBEntities();

        public Usuario UsuarioObtener(int id)
        {
            try
            {
                Usuario user = (from objUsu in db.Usuarios
                                where objUsu.UsuarioID.Equals(id)
                                select objUsu).SingleOrDefault();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario UsuarioAutenticar(string iDNI, string icontraseña)
        {
            try
            {
                Usuario user = (from obj in db.Usuarios where obj.DNI.Equals(iDNI) && obj.Contraseña.Equals(icontraseña) select obj).SingleOrDefault();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> UsuariosBuscar()
        {
            try
            {
                IQueryable<Usuario> lstUsuarios = from objUsuario in db.Usuarios
                                                  select objUsuario;

                return lstUsuarios.ToList();

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public int UsuarioInsertar(Usuario objUsuario)
        {
            try
            {
                db.Usuarios.Add(objUsuario);
                db.SaveChanges();
                return objUsuario.UsuarioID;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UsuarioActualizar(Usuario objUsuarioAct)
        {
            try
            {
                Usuario objUsuario = (from objUsu in db.Usuarios
                                      where objUsu.UsuarioID.Equals(objUsuarioAct.UsuarioID)
                                      select objUsu).SingleOrDefault();

                objUsuario.Nombre = objUsuarioAct.Nombre;
                objUsuario.Contraseña = objUsuarioAct.Contraseña;
                objUsuario.Apellido = objUsuarioAct.Apellido;
                objUsuario.Correo = objUsuarioAct.Correo;
                objUsuario.Telefono = objUsuarioAct.Telefono;

                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UsuarioEliminar(int iCodUsuario)
        {
            try
            {
                Usuario objUsuario = (from objUsu in db.Usuarios
                                      where objUsu.UsuarioID.Equals(iCodUsuario)
                                      select objUsu).SingleOrDefault();

                db.Usuarios.Remove(objUsuario);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}