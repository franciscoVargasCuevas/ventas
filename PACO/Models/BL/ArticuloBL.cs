using PACO.Models.DAL;
using PACO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PACO.Models.BL
{
    public class ArticuloBL
    {
        ArticuloDAL dal = new ArticuloDAL();
        public List<ArticuloViewModel> getArticulo()
        {
            return dal.getArticulo();
        }

        public void setNewArticulo(ArticuloViewModel model)
        {
            try
            {
                dal.setArticulo(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ArticuloViewModel putArticulo(int id)
        {
            return dal.putArticulo(id);
        }

        public bool putArticulo(ArticuloViewModel model)
        {
            dal.putArticulo(model);
            return true;
        }

        public void delArticulo(int id)
        {
            dal.delArticulo(id);
        }

    }
}