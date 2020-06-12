using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vscommerce.User;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using vscommerce.user;
using vscommerce.admin;

namespace vscommerce
{
    public partial class login : MaterialForm
    {
        public login()
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }


        private void loginSubmit(object sender, EventArgs e)
        {
            try
            {   
                // get data from inputs
                UserManagerClient userManager = new UserManagerClient(); //initialize
                string mail = email.Text;
                string passwordMD5= GenerateMd5Hash(password.Text);

                //call user manager fuction to login
                if (userManager.Login(mail, passwordMD5))
                {
                    User.User loggedUser = userManager.getUserByEmail(mail);
                    this.Hide();//i am logged in so i don't need the login form

                    if (!loggedUser.isAdmin)
                    {
                        userHome userPanel = new userHome(loggedUser); //initialize a new user form
                        userPanel.Show();
                        
                    }
                    else
                    {
                        adminPanel adminPanel = new adminPanel(loggedUser); //initialize a new admin form
                        adminPanel.Show(); //send to the new form
                    }

                }
                else
                    MessageBox.Show("Credenziali", "Utente/Password errati.", MessageBoxButtons.OK);//Error Message

            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore", "Errore nella connessione al server.", MessageBoxButtons.OK);
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

        private void signinButton_Click(object sender, EventArgs e)
        {
            signinForm signin = new signinForm();
            signin.Show();
        }
    }
}
