using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class FormLogin : Form
    {
        int i = 1;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {

            if (i <= 2)
            {
                if (txtName.Text == "BTS" && txtPassword.Text == "13062013")
                {
                    Formshow fs = new Formshow();
                    fs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: The User name or password you entered is incorrect,try again","Notification");
                    txtName.Clear();
                    txtPassword.Clear();
                    txtName.Focus();

                }
            }
            else if(i==3)
            {
                if (txtName.Text == "BTS" && txtPassword.Text == "13062013")
                {
                    Formshow fs = new Formshow();
                    fs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Fail:log in ຜິດພາດ 3 ຄັ້ງແລ້ວ,ບໍ່ສາມາດທຳການLoginໄດ້ເທື່ອ", "Notification");
                    txtName.Clear();
                    txtPassword.Clear();
                    txtName.Focus();
                }
            }
            else if (i > 4)
            {
                MessageBox.Show("Fail: Wrong more than 3 times already ","Notification");
                this.Close();
            }
            i++;
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
