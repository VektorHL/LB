using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        DB db = new DB();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        //это я прописал и потом принудительно поиндексно присвоил чисто ради удобства
        String[] movesType_comboBox_Collection = new String[] { "Отчёт по сотруднику за день",
                                                "Отчёт по сотрудникам за день",
                                                "Отчёт по помещению за день" };

        public MainWindow()
        {
            InitializeComponent();

            getMoves_movesType_comboBox.Text = "Вид отчёта";

            names_comboBox.Text = "ФИО";
            getMoves_names_comboBox.Text = "ФИО";
            //names_comboBox.ForeColor = Color.Gray;

            rooms_comboBox.Text = "Помещение";
            getMoves_rooms_comboBox.Text = "Помещение";
            //rooms_comboBox.ForeColor = Color.Gray;

            //команда для получения списка помещений
            MySqlCommand cmd = new MySqlCommand("SELECT `room` FROM `rooms`", db.getConnection());

            db.openConnection();//открываем соединение, чтобы контачить с БД

            DbDataReader dataReader = cmd.ExecuteReader();//создаём ридер, чтоб он читал поток строк от команды 

            while (dataReader.Read())//читаем построчно, пока строки есть
            {
                //добавляем значения из БД в список comboBox -ов
                rooms_comboBox.Items.Add(dataReader["room"].ToString());
                getMoves_rooms_comboBox.Items.Add(dataReader["room"].ToString());
            }

            db.closeConnection();//закрываем соединение
            db.openConnection();//открываем новое для нового запроса

            cmd = new MySqlCommand("SELECT CONCAT(`fName`, ' ', `sName`, ' ', `tName`) as fullName FROM `members`", db.getConnection());
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                names_comboBox.Items.Add(dataReader["fullName"].ToString()) ;
                getMoves_names_comboBox.Items.Add(dataReader["fullName"].ToString());
            }

            db.closeConnection();

            for (int i = 0; i < movesType_comboBox_Collection.Length; i++)
            {
                getMoves_movesType_comboBox.Items[i] = movesType_comboBox_Collection[i];
            }
        }


        //таблица для удобства вёрстки
        private void MainWindow_tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //
        private void moves_label_Click(object sender, EventArgs e)
        {

        }


        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void getMoves_movesType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getMoves_button_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand cmd = new MySqlCommand();

            switch (getMoves_movesType_comboBox.Text)
            {
                case "Отчёт по сотруднику за день":
                    cmd = new MySqlCommand("", db.getConnection());

                    
                    break;
                case "Отчёт по сотрудникам за день":
                    


                    break;
                case "Отчёт по помещению за день":
                    


                    break;
            }

            //cmd.ExecuteReader();

            db.closeConnection();
        }

        private void getMoves_rooms_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void names_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rooms_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IN_button_Click(object sender, EventArgs e)
        {
            String insert = "INSERT INTO `statistic` (`id`, `member_id`, `room_id`, `dateTime`) VALUES" + "(NULL, ";
            
            //подзапросы для главного запроса. получают id выбранного в окне работника и помещения соответственно
            String memberIdGet = "(SELECT id FROM `members` WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + names_comboBox.Text + "'), ";
            String roomIdGet = "(SELECT id FROM `rooms` WHERE `room` = '" + rooms_comboBox.Text + "'), NOW())";

            
            db.openConnection();
            
            //запрос для вставки
            MySqlCommand cmd = new MySqlCommand(insert + memberIdGet + roomIdGet, db.getConnection());
            cmd.ExecuteNonQuery();

            db.closeConnection();

            //MessageBox.Show("Запись добавлена");
        }
    }
}
