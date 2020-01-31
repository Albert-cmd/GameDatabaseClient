using GamesAPiClient.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesAPiClient.View
{
    public partial class Popout : Form
    {
        //public LoginController lc;

        public Popout()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
            /*lc.popout = null;

            lc.username = "";
            lc.password = "";
            lc.login.usernameInput.Text = "";
            lc.login.passwordInput.Text = "";*/

        }
    }
}
