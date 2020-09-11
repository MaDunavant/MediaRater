using System;
using System.Collections.Generic;
using System.Text;

namespace MediaRaterAPI.DAL
{
    public class UsersSQLDAO : IUsersDAO
    {
        private string connectionString;
        public UsersSQLDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
