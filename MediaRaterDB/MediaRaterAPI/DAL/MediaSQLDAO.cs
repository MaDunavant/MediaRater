using System;
using System.Collections.Generic;
using System.Text;

namespace MediaRaterAPI.DAL
{
    public class MediaSQLDAO : IMediaDAO
    {
        private string connectionString;
        public MediaSQLDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
