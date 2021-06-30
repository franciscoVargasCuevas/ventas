using PACO.Models.DAL;
using PACO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PACO.Models.BL
{
    public class TiendaBL 
    {
        TiendaDAL data = new TiendaDAL();
        public List<TiendaViewModel> getTienda()
        {
            return data.getTienda();
        }

        public void setNewTienda(TiendaViewModel model)
        {
            try
            {
                data.setNewTienda(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TiendaViewModel putTienda(int id)
        {
            return data.putTienda(id);
        }

        public bool putTienda(TiendaViewModel model)
        {
            data.putTienda(model);
            return true;
        }

        public void delTienda(int id)
        {
            data.delTienda(id);
        }

    }//class
}