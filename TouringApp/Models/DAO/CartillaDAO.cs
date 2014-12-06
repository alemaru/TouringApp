using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using TouringApp.Models.TO;

namespace TouringApp.Models.DAO
{
    public class CartillaDAO
    {
        /// <summary>
        /// Implementacion del patron Singleton a la clase Cartilla
        /// </summary>
        private static CartillaDAO instance = null;
        protected CartillaDAO() { }
        public static CartillaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CartillaDAO();
                return instance;
            }
        }

        /// <summary>
        /// Implementacion de las funciones
        /// </summary>
        private TouringDBEntities db = new TouringDBEntities();

        public Cartilla CartillaObtener(int id)
        {
            try
            {
                Cartilla cart = (from objCar in db.Cartillas
                                 where objCar.UsuarioID.Equals(id)
                                 select objCar).SingleOrDefault();

                if (cart == null)
                {
                    Cartilla objCartilla = new Cartilla();
                    objCartilla.UsuarioID = id;
                    db.Cartillas.Add(objCartilla);
                    db.SaveChanges();
                    cart = objCartilla;
                }
                return cart;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CartillaActualizar(Cartilla objCartillaAct)
        {
            try
            {
                Cartilla objCartilla = (from objCar in db.Cartillas
                                       where objCar.UsuarioID.Equals(objCartillaAct.UsuarioID)
                                       select objCar).SingleOrDefault();

                objCartilla.Ex_escrito = objCartillaAct.Ex_escrito;
                objCartilla.Ex_medico = objCartillaAct.Ex_medico;
                objCartilla.Ex_practico = objCartillaAct.Ex_practico;
                objCartilla.Comentario = objCartillaAct.Comentario;

                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}