using System;
using System.Configuration;

namespace MSGProject.Controller
{
    public static class Helper
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    }
}
