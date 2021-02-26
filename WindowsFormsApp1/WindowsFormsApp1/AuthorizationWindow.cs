using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AuthorizationWindow : Form
    {
        //конструктор для окна авторизации
        public AuthorizationWindow()
        {
            InitializeComponent();

            //скрывает символы пароля
            //this.PasswordInput_textBox.UseSystemPasswordChar = true;
        }

        private void AuthorizationWindow_Load(object sender, EventArgs e)
        {

        }

        //надпись "Введите пароль для использования". ХЗ почему оно с пометкой КЛИК создалось
        private void PasswordInput_Label_Click(object sender, EventArgs e)
        {

        }

        //поле для ввода пароля
        private void PasswordInput_textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //кнопка "ОК" для отправки пароля на проверку. Действие после клика на неё
        private void Password_OK_Botton_Click(object sender, EventArgs e)
        {
            this.PasswordInput_textBox.Text = "Кнопка ОК работает";
        }
    }
}
