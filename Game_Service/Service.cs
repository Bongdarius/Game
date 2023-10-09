using Game_Dao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Service
{
    public class Service
    {
        private static string conn = "server='localhost'; database='GAME'; uid='sa'; pwd='1234';";

        public int login(string uid, string pwd)
        {
            Login_Dao login_Dao = new Login_Dao();

            int result = login_Dao.login(conn, uid, pwd);

            return result;
        }

        public int signup(string uid, string pwd)
        {
            Login_Dao login_Dao = new Login_Dao();

            int result = login_Dao.signup(conn, uid, pwd);

            return result;
        }
    }
}
