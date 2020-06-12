using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using vscommerce.User;

namespace vscommerce.user
{
    public partial class signinForm : MaterialForm
    {
        UserManagerClient userManager;
        public signinForm()
        {
            this.userManager = new UserManagerClient();
            InitializeComponent();
            MaterialSkinManager materialUIManager = MaterialSkinManager.Instance;
            materialUIManager.AddFormToManage(this);
            materialUIManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialUIManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.DeepOrange400,
                TextShade.WHITE
                );
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (this.userFieldsValidation())
            {
                
                if (this.userManager.existUser(userEmail.Text))
                {
                    MessageBox.Show("Esiste gia un account con questa email");
                }
                else
                {
                    User.User user = new User.User();
                    user.name = userName.Text;
                    user.surname = userSurname.Text;
                    user.email = userEmail.Text;
                    user.birthday = userBirthday.Value;
                    user.fiscalCode = userFiscalcode.Text;
                    user.password = GenerateMd5Hash(userPassword.Text);
                    user.isAdmin = false;
                    if (userManager.createUser(user))
                    {
                        MessageBox.Show("Utente registrato con successo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Errore alla registrazione dell'utente");
                    }
                }
            }
        }

        private bool userFieldsValidation()
        {

            if (string.IsNullOrWhiteSpace(userName.Text))
            {
                errorProviderApp.SetError(userName, "Non hai compilato il nome");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(userSurname.Text))
            {
                errorProviderApp.SetError(userSurname, "Non hai compilato il cognome");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(userFiscalcode.Text) || !Regex.IsMatch(userFiscalcode.Text.ToUpper(), @"^[A-Z]{6}[0-9]{2}[A-Z][0-9]{2}[A-Z][0-9]{3}[A-Z]$"))
            {
                errorProviderApp.SetError(userFiscalcode, "Non hai compilato il codice fiscale");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(userEmail.Text))
            {
                errorProviderApp.SetError(userEmail, "Non hai compilato l'Email");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(userPassword.Text))
            {
                errorProviderApp.SetError(userPassword, "Non hai compilato la password");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(userPassword2.Text))
            {
                errorProviderApp.SetError(userPassword2, "Non hai confermato la password");
                return false;
            }
            else if (userPassword.Text != userPassword2.Text)
            {
                errorProviderApp.SetError(userPassword, "Le password non combaciano");
                errorProviderApp.SetError(userPassword2, "Le password non combaciano");
                return false;
            }
            else
            {
                return true;

            }
        }
        private static string GenerateMd5Hash(string input)
        {
            var x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var computeHash = System.Text.Encoding.UTF8.GetBytes(input);
            computeHash = x.ComputeHash(computeHash);
            var stringBuilder = new System.Text.StringBuilder();
            foreach (var str in computeHash)
            {
                stringBuilder.Append(str.ToString("x2").ToLower());
            }
            return stringBuilder.ToString();
        }
    }
}
