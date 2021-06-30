using PACO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PACO.Models.DAL
{
    public class ArticuloDAL
    {
        public List<ArticuloViewModel> getArticulo()
        {
            List<ArticuloViewModel> lst = null;
            using (VENTAEntities db = new VENTAEntities())
            {
                lst = (from d in db.ARTICULOS
                       select new ArticuloViewModel
                       {
                           id = d.ID_ARTICULO,
                           codigo = d.CODIGO,
                           descripcion = d.DESCRIPCION,
                           precio = d.PRECIO,
                           imagen = d.IMAGEN,
                           stock = d.STOCK
                       }).ToList();
            }
            return lst;
        }

     
        public void setArticulo(ArticuloViewModel model)
        {
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = new ARTICULOS();
                oTabla.ID_ARTICULO = model.id;
                oTabla.CODIGO = model.codigo;
                oTabla.DESCRIPCION = model.descripcion;
                oTabla.PRECIO = model.precio;        
                oTabla.IMAGEN = model.imagen;
                oTabla.STOCK = model.stock;

                db.ARTICULOS.Add(oTabla);
                db.SaveChanges();
            }
        }

        public ArticuloViewModel putArticulo(int id)
        {
            ArticuloViewModel model = new ArticuloViewModel();
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = db.ARTICULOS.Find(id);
                model.codigo = oTabla.CODIGO;
                model.descripcion = oTabla.DESCRIPCION;
                model.precio = oTabla.PRECIO;
                model.id = oTabla.ID_ARTICULO;
                model.imagen = oTabla.IMAGEN;
                model.stock = oTabla.STOCK;
            }
            return model;
        }

        public bool putArticulo(ArticuloViewModel model)
        {
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = db.ARTICULOS.Find(model.id);
                oTabla.CODIGO = model.codigo;
                oTabla.DESCRIPCION = model.descripcion;
                oTabla.PRECIO = model.precio;
                oTabla.IMAGEN = model.imagen;
                oTabla.STOCK = model.stock;
               
                db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return true;
        }

        public void delArticulo(int id)
        {
            using (VENTAEntities db = new VENTAEntities())
            {
                var oTabla = db.ARTICULOS.Find(id);
                db.ARTICULOS.Remove(oTabla);
                db.SaveChanges();
            }
        }


    }
}