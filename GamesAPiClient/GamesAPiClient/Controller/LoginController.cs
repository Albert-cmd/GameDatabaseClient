﻿using GamesAPiClient.Model;
using GamesAPiClient.View;
using ModelV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GamesAPiClient.Controller
{

    public class LoginController
    {

        public Login login;

        public string username = "";
        public string password = "";

        private string hash = "";

        public LoginController() {

            login = new Login();

            triggersLogin();

            login.Show();
        }

        public void triggersLogin()
        {

            login.usernameInput.TextChanged += usernameInputChanged;
            login.passwordInput.TextChanged += passwordInputChanged;

            login.loginButton.Click += loginClick;
            login.registerButton.Click += registreClick;
            //login.tempButton.Click += tempClick;

        }

        /*private void tempClick(object sender, EventArgs e)
        {

            IniciarBase();

        }*/

        private void passwordInputChanged(object sender, EventArgs e)
        {
            password = "";

            try
            {
                password = login.passwordInput.Text.ToString();
            }
            catch (Exception ex)
            {

                password = "";

            }
        }

        private void usernameInputChanged(object sender, EventArgs e)
        {

            username = "";

            try
            {
                username = login.usernameInput.Text.ToString();
            }
            catch (Exception ex)
            {

                username = "";

            }

        }

        private void loginClick(object sender, EventArgs e)
        {

            loginVoid();

        }

        public void loginVoid()
        {
            Console.WriteLine("Login?");
            checkHash(password);

        }


        private void registreClick(object sender, EventArgs e)
        {
            registreVoid();
        }

        public void registreVoid()
        {

            hasher(password);

        }

        public void hasher(string password)
        {

            using (var deriveBytes = new Rfc2898DeriveBytes(password, 20))
            {
                byte[] salt = deriveBytes.Salt;
                byte[] key = deriveBytes.GetBytes(20);  // derive a 20-byte key

                // save salt and key to database
                Console.WriteLine("SALT: " + Encoding.Default.GetString(salt));
                Console.WriteLine("KEY: " + Encoding.Default.GetString(key));

                user u = new user(username, key, salt);
                InsertUser(u);

            }

        }

        public void InsertUser(user u) {

            LoginRepository.InsertUser(u);

        }

        public void checkHash(string password)
        {

            // comprova si la password és correcte

            // load salt and key from database

            user u = LoginRepository.GetUsuari(username);

            try
            {
                byte[] salt = u.salt;
                byte[] key = u.key;

                using (var deriveBytes = new Rfc2898DeriveBytes(password, salt))
                {
                    byte[] newKey = deriveBytes.GetBytes(20);  // derive a 20-byte key

                    if (!newKey.SequenceEqual(key))
                    {
                        Console.WriteLine("Password is invalid!");
                    }
                    else
                    {
                        Console.WriteLine("Password is valid!");
                        IniciarBase();

                        // tanca login form

                        login.Hide();
                        login.Close();
                    }

                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }

        }

        public void IniciarBase() {

            BaseController bc = new BaseController();

        }

    }
}
