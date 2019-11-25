using MOD_AuthenticationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_AuthenticationService.Repositories
{
    public interface ILoginRepository
    {
        User UserLogin(string UserEmail, string UserPassword);
        Mentor MentorLogin(string MentorEmail, string MentorPassword);
    }
}
