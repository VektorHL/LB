using MySql.Data.MySqlClient; //нужно для подключения к БД
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    class DB
    {
        
        //переменная с данными о серваке и БД
        MySqlConnection connection = new MySqlConnection("Server=localhost;Port=5432;Database=LittleBrother;User Id=user;Password=parol");//хз, вроде должно работать. не прверял

        //метод для открытия соединения
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //метод для зарытия соединения
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        //возвращает переменную в инфой о БД
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
