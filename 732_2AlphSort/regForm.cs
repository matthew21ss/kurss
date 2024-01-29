using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _732_2AlphSort
{
    public partial class regForm : Form
    {
        private DBManager dbmanager;
        public regForm(DBManager dbmanager)
        {
            InitializeComponent();
            this.dbmanager = dbmanager;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string login = regLoginTB.Text;
            string pwd1 = regPwd1TB.Text;
            string pwd2 = regPwd2TB.Text;

            if (login.Length < 3)
            {
                MessageBox.Show("Логин не может быть короче трех символов");
                return;
            }

            if (pwd1.Length < 6)
            {
                MessageBox.Show("Пароль не может быть короче шести символов");
                return;
            }

            if (!pwd1.Equals(pwd2))
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if (dbmanager.CheckLogin(login))
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован!");
                return;
            }

            if (dbmanager.AddUser(login, pwd1))
            {
                MessageBox.Show("Успешная регистрация");
            }
            else
            {
                MessageBox.Show("Не удалось зарегистрировать пользователя");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void regLoginTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void regForm_Load(object sender, EventArgs e)
        {
        }
    }
}