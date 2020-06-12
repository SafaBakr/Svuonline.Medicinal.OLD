using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svuonline.Medicinal.DataAccessLayer;
using Svuonline.Medicinal.BussinessObjectLayer;

namespace Svuonline.Medicinal.BussinesslogicLayer
{

    public static class ClsUserAccountsServices
    {
        static IUserAccountsRepository Repository;
        static ClsUserAccountsServices()
        {
            Repository = new ClsUserAccountsDataAccess();
        }
        public static UserAccount Insert(UserAccount UserAccountObj)
        {
            return Repository.Insert(UserAccountObj);
        }
    }
}
