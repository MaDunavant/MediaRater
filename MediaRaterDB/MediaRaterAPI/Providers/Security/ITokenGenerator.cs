using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRaterAPI.Providers.Security
{
    /// <summary>
    /// Represents an authentication token interface.
    /// </summary>
    public interface ITokenGenerator
    {
        /// <summary>
        /// Generates a new authentication token.
        /// </summary>
        /// <param name="username">The user's username</param>
        /// <param name="role">The user's role</param>
        /// <returns></returns>
        string GenerateToken(string username, string role);
    }
}
