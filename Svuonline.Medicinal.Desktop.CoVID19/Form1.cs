using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svuonline.Medicinal.BussinesslogicLayer;
using Svuonline.Medicinal.BussinessObjectLayer;

namespace Svuonline.Medicinal.Desktop.CoVID19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SUN="  ";
            String UEA="safa@safa.com";
            String Pwd="12345";
            int URID=1;
            UserAccount userAccountObj = new UserAccount
            {
                ScreenUserName = SUN,
                UserEmailAddress = UEA,
                Password = Pwd,
                UserRoleID = URID,
            };
            ClsUIVaildator UserInterfaceValidatorObj = new ClsUIVaildator();
            String ErrorMsg = "هذا الحقل مطلوب!";
            if (UserInterfaceValidatorObj.TxtBoxValidator(SUN) == 1)
            {
                button1.Focus();
                TxtBoxerrorProvider.SetError(button1, ErrorMsg);
                button1.FlatAppearance.BorderSize = 2;
                button1.FlatAppearance.BorderColor = Color.Red;
                button1.BackColor = ColorTranslator.FromHtml("#ff0033");
                button1.ForeColor = ColorTranslator.FromHtml("#ffcdc9");
                button1.Font = new Font("", 10, FontStyle.Bold);
            }
            ClsUserAccountsServices.Insert(userAccountObj);
        }
    }
}
