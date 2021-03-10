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
    public partial class MemberWayWindow : Form
    {
        DB db = new DB();

        string _member;
        string _room;

        //DataTable table = new DataTable();

        public MemberWayWindow(string memberName, string roomName)
        {
            InitializeComponent();
            //string member;
            //string room;

            _member = memberName;
            _room = roomName;

            LoadDataTaining();

        }

        private void LoadDataTaining()
        {
            //throw new NotImplementedException();

            string query = "SELECT `date`, " +
                "CONCAT(`fName`, ' ', `sName`, ' ', `tName`) AS name, " +
                "`room`, " +
                "`time_in`, `time_out`, " +
                "ABS(`time_out` - `time_in`) AS duration " +
                "FROM `st`, `members`, `rooms`" +
                "WHERE `time_out` IS NOT NULL " +
                "AND `date` = CURRENT_DATE() " +
                "AND CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + _member + "' " +
                "AND room_id = rooms.id";

            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

            db.openConnection();

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
            db.closeConnection();

            foreach (string[] row in data)
            {
                dataGridView.Rows.Add(row);
            }
        }
    }
}
