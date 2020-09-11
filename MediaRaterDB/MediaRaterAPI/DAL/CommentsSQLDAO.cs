using System;
using System.Collections.Generic;
using System.Text;

namespace MediaRaterAPI.DAL
{
    public class CommentsSqlDAO : ICommentsDAO
    {
        private string connectionString;
        public CommentsSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
