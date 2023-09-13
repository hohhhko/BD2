using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЬДК_301
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
  
    }
    static class DataBase
    {
        public static string ConnetctionString = @"Data Source= DBPeploe.db; Integrated Security=False; MultipleActiveResultSets=True";
    }
    #region table

    static class Table_Peapol
    {
        public static string main = "Peapol";
        public static string ID = "ID";
        public static string Name = "Name";
        public static string Surname = "Surname";
        public static string Photo = "Photo";
    }
    static class Table_Photo
    {
        public static string main = "Photo";
        public static string ID = "ID";
        public static string Photo_Pepole = "Photo_Pepole";
    
    }
    static class Table_sqlite_sequence
    {
        public static string main = "sqlite_sequence";
        public static string name = "name";
        public static string seq = "seq";
    }
    #endregion

}

