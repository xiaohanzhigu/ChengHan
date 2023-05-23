using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChengHan.DAL
{
    internal class DB
    {
        public static string GetConstr()
        {
            return System.Configuration.ConfigurationManager.AppSettings["constr"].ToString();
        }
    }
}
