using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();

            LoginButton.Enabled = false;

        }

        private void PassCodeBox_TextChanged(object sender, EventArgs e)
        {
            SetPassCodeBox();
        }

        private void SetPassCodeBox()
        {
            if (double.Parse(PassCodeBox.Text) > 0)
            {
                LoginButton.Enabled = true;
            }
            else
            {
                LoginButton.Enabled = false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
          
            using (MainMenu f = new MainMenu())
            {
                f.ShowDialog();
            } ;
           
        }

    }
}
