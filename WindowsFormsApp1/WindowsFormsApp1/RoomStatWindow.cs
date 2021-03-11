using MySql.Data.MySqlClient;
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
    public partial class RoomStatWindow : Form
    {
        DB db = new DB();

        string _memberName;
        string _room;

        public RoomStatWindow(string member, string room)
        {
            _memberName = member;
            _room = room;

            InitializeComponent();
            LoadDataTaining();
            
            this.Text = _memberName + ". Пребывание в зонах за текузий месяц";
        }

        private void LoadDataTaining()
        {
            string connection = "server=localhost; port=3306; username=root; password=root; database=littlebrother";

            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            mySqlConnection.Open();

            string query = "SELECT DATE_FORMAT(`date`, '%d.%m.%Y') AS date, " +
                    "CONCAT(`fName`, ' ', `sName`, ' ', `tName`) AS name, " +
                    "`room`, " +
                    "`time_in`, `time_out`, " +
                    "TIMEDIFF(`time_out`, `time_in`) AS duration " +
                "FROM `st`, `members`, `rooms` " +
                "WHERE `time_out` IS NOT NULL " +
                "AND `date` = CURRENT_DATE() - 1 " +
                "AND CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + _memberName + "' " +
                "AND room_id = rooms.id";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();
            mySqlConnection.Close();

            dataGridView.Rows.Clear();
            foreach (string[] row in data)
            {
                dataGridView.Rows.Add(row);
            }
        }
    }
}
