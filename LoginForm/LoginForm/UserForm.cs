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
            if (PassCodeBox.Text.Length == 6)
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
            // yyyymm 形式の文字列を DateTime に変換 → 自動的に 1 日になります。
            var dt = System.DateTime.ParseExact(PassCodeBox.Text, "yyyyMM", null);
            // MessageBox.Show(dt.ToString());  
            var now = DateTime.Now;
 
            if (dt.AddYears(1) >=  now)
            {
                using (MainMenu f = new MainMenu())
                {
                    f.ShowDialog();
                };
            }
            else
            {
                MessageBox.Show("有効期限が切れています");
            }
           
           
        }

        //PassCodeBoxのKeyPressイベントハンドラ
        private void PassCodeBox_KeyPress(object sender,
            System.Windows.Forms.KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
