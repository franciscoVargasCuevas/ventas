using PACO.Models.DAL;
using PACO.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PACO.Models.BL
{
    public class ClienteBL
    {
        ClienteDAL dal = new ClienteDAL();
        public List<ClienteViewModel> getClient() {
            return dal.getClient();
        }

        public void setNewClient(ClienteViewModel model) {
            try
            {
                dal.setNewClient(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteViewModel putClient(int id)
        {
            return dal.putClient(id);
        }

        public bool putClient(ClienteViewModel model)
        {
            dal.putClient(model);
            return true;
        }

        public void delClient(int id)
        {
            dal.delClient(id);
        }


    }
}