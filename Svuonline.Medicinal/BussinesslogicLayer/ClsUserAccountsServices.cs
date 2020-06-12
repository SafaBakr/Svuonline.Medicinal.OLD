using System.Linq;
using Svuonline.Medicinal.DataAccessLayer;
using Svuonline.Medicinal.BussinessObjectLayer;
using System.Windows.Forms;

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
            if(Repository.GetAll().Any(User => User.ScreenUserName == UserAccountObj.ScreenUserName))
            {
                MessageBox.Show("اسم المستحدم موجود مسبقاً", "رسـالـة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return UserAccountObj;
            }
            else if (Repository.GetAll().Any(User => User.UserEmailAddress == UserAccountObj.UserEmailAddress))
            {
                MessageBox.Show("الإيميل المدخل موجود مسبقاً", "رسـالـة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return UserAccountObj;
            }
            else
            {
            return Repository.Insert(UserAccountObj);
            }
        }
    }
}
