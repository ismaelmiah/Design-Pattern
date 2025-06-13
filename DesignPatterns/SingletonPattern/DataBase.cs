using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class DataBase
    {
        public static DataBase Instance;

        private DataBase()
        {
            // Private constructor to prevent instantiation from outside
        }

        public static DataBase GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DataBase();
            }
            return Instance;
        }
    }
}
