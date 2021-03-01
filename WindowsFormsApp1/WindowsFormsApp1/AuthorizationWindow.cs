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

            PasswordInput_textBox.Text = "Введите пароль";
            PasswordInput_textBox.ForeColor = Color.Gray;

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
            //this.PasswordInput_textBox.Text = "вы нажали ОК";

            //PasswordInput_textBox.Text = "SELECT * FROM \"userPassword\" WHERE password = '@pswd'";
            String userPassword = PasswordInput_textBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM \"userPassword\" WHERE 'password' = @pswd", db.getConnection());
            MySqlCommand command = new MySqlCommand("SELECT * FROM `userpasswords` WHERE `password` = @pswd", db.getConnection());

            command.Parameters.Add("@pswd", MySqlDbType.VarChar).Value = userPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("HURRAY!");
                //тут надо открыть новое окно для использования и закрыть это с авторизацией
            }
            else
            {
                MessageBox.Show("Неверный пароль. Попробуйте снова.");
            }

            //Npgsql
            //NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=LittleBrother;User Id=user;Password=123");
            //conn.Open();
            //NpgsqlCommand com = new NpgsqlCommand();
            //com.Connection = conn;
            //com.CommandType = CommandType.Text;
            //com.CommandText = "SELECT * FROM \"userPassword\" WHERE password = '@pw" + userPassword + "'";
            //command.Parameters.Add("@pw", MySqlDbType.Text).Value = userPassword;
            //NpgsqlDataReader dr = com.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    MessageBox.Show("yes");
            //    //DataTable dt = new DataTable();
            //    //dt.Load(dr);
            //}
            //else
            //{
            //    MessageBox.Show("no");
            //}
        }


        //по нажатию на поле первый раз после запуска программы, очищает его
        private void PasswordInput_textBox_Enter(object sender, EventArgs e)
        {
            if(PasswordInput_textBox.Text == "Введите пароль")
            {
                PasswordInput_textBox.Text = "";
                PasswordInput_textBox.ForeColor = Color.Black;
            }

        }

        //если поле пустое
        private void PasswordInput_textBox_Leave(object sender, EventArgs e)
        {
            if (PasswordInput_textBox.Text == "")
            {
                PasswordInput_textBox.Text = "Введите пароль";
                PasswordInput_textBox.ForeColor = Color.Red;
            }

        }
    }
}
