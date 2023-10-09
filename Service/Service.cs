using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao_;

namespace Service_
{
    public class Service
    {
        public string conn = "server='localhost'; database='GAME' uid='sa'; pwd='1234';";

        public ArrayList login(string uid, string pwd)
        {
            ArrayList arrayList = new ArrayList();

            Login login = new Login();

            return arrayList;
        }
    }
}
