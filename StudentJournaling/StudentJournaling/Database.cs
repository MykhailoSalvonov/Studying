using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentJournaling
{
    internal class Database
    {
        string dbFilePath = "D:\\Git\\Studying\\StudentJournaling\\db\\database.db";


        public Database() 
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                // Тут ви можете створити таблиці і виконувати інші операції з базою даних
            }
        }
    }
}
