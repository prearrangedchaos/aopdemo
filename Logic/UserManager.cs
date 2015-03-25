using System;
using System.Text.RegularExpressions;
using AOPDemo.Aspects;
using AOPDemo.Model;
using PostSharp.Extensibility;
using PostSharp.Patterns.Contracts;

namespace AOPDemo.Logic
{
    public class UserManager
    {
        private LoggerService _logger;
        private SecurityService _security;

        public UserManager()
        {
            this._logger = new LoggerService();
            this._security = new SecurityService();
        }

        [LoggingAspect]
        [ExceptionHandlerAspect]
        [AuthorizeAspect(Permission.AddUser)]
        public User AddUser(string userName, string fullName)
        {
                User newUser = new User(userName, fullName);
                // do something with new user - like persist

                return newUser;
        }
    }
}
