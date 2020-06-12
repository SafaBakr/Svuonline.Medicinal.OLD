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
        ClsUIVaildator UserInterfaceValidatorObj = new ClsUIVaildator();
        public Form1()
        {
            InitializeComponent();
            txtBoxScreenUserName.MaxLength = 15;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            String SUN= txtBoxScreenUserName.Text.Trim();
            String UEA= txtBoxUserEmail.Text.Trim();
            String Pwd="12345";
            int URID=1;
            UserAccount userAccountObj = new UserAccount
            {
                ScreenUserName = SUN,
                UserEmailAddress = UEA,
                Password = Pwd,
                UserRoleID = URID,
            };
            String ErrorMsg = "!..هذا الحقل مطلوب";
            if (UserInterfaceValidatorObj.TxtBoxValidator(SUN) == 1)
            {
                txtBoxScreenUserName.Focus();
                TxtBoxerrorProvider.SetError(txtBoxScreenUserName, ErrorMsg);
                txtBoxScreenUserName.FlatAppearance.BorderSize = 2;
                txtBoxScreenUserName.FlatAppearance.BorderColor = Color.Red;
                txtBoxScreenUserName.BackColor = ColorTranslator.FromHtml("#ff0033");
                txtBoxScreenUserName.ForeColor = ColorTranslator.FromHtml("#ffcdc9");
                txtBoxScreenUserName.Font = new Font("", 10, FontStyle.Bold);
                return;
            }
            else if (UserInterfaceValidatorObj.EmailValidator(UEA))
                {
                TxtBoxerrorProvider.Clear();
                txtBoxScreenUserName.FlatAppearance.BorderSize = 1;
                txtBoxScreenUserName.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#252526");
                txtBoxScreenUserName.BackColor = ColorTranslator.FromHtml("#f0f0f0");
                txtBoxScreenUserName.ForeColor = ColorTranslator.FromHtml("#000000");
                txtBoxScreenUserName.Font = new Font("", 9, FontStyle.Regular);
                try
                {
                    ClsUserAccountsServices.Insert(userAccountObj);
                    MessageBox.Show("تم تسجيل البيانات بنجاح", "رسـالـة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("حدثت مشكلة أثناء تخزين البيانات", "رسـالـة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(" !..غـير صحيح   " + UEA + "  :هذا الإدخـال", "رسـالـة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void txtBoxScreenUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserInterfaceValidatorObj.InputcharCheck(e);
        }
    }
}
