using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvernoteClone.ViewModel.Helpers
{
    public class DatabaseHelper
    {
        private static string dbFile = Path.Combine(Environment.CurrentDirectory, "notesDb.db3");

        public static bool Insert<T>(T item)
        {
            bool result = false;

            using(SQLiteConnection connection = new SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                int rows = connection.Insert(item);
                if(rows > 0)
                {
                    result = true;
                }
            }

            return result;
        }
        public static bool Update<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection connection = new SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                int rows = connection.Update(item);
                if (rows > 0)
                {
                    result = true;
                }
            }

            return result;
        }
        public static bool Delete<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection connection = new SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                int rows = connection.Delete(item);
                if (rows > 0)
                {
                    result = true;
                }
            }

            return result;
        }
            //where T : new() ensures that T is parameterless constructor, a requirement to call Table<T>()
        public static List<T>Read<T>() where T : new()
        {

            List<T> items;
            using (SQLiteConnection connection = new SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                items = connection.Table<T>().ToList();
            }

            return items;
        }

    }
}
