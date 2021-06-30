using PACO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PACO.Models.DAL
{
    public class TiendaDAL
    {

        public List<TiendaViewModel> getTienda()
        {
            List<TiendaViewModel> lst = null;
            using (VENTAEntities db = new VENTAEntities())
            {
                lst = (from d in db.TIENDA
                       select new TiendaViewModel
                       {
                           id = d.ID_TIENDA,
                           sucursal = d.SUCURSAL,
                           direccion = d.DIRECCION
                       }).ToList();

            }
            return lst;
        }

        public void setNewTienda(TiendaViewModel model)
        {
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = new TIENDA();
                oTabla.ID_TIENDA = model.id;
                oTabla.SUCURSAL = model.sucursal;
                oTabla.DIRECCION = model.direccion;
             
                db.TIENDA.Add(oTabla);
                db.SaveChanges();
            }
        }

        public TiendaViewModel putTienda(int id)
        {
            TiendaViewModel model = new TiendaViewModel();
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = db.TIENDA.Find(id);
                model.id = oTabla.ID_TIENDA;
                model.sucursal = oTabla.SUCURSAL;
                model.direccion = oTabla.DIRECCION;
                            }
            return model;
        }

        public bool putTienda(TiendaViewModel model)
        {
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = db.TIENDA.Find(model.id);
                oTabla.SUCURSAL = model.sucursal;
                oTabla.DIRECCION = model.direccion;
                
                db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }

        public void delTienda(int id)
        {
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = db.TIENDA.Find(id);
                db.TIENDA.Remove(oTabla);
                db.SaveChanges();
            }
        }


    }//class
}