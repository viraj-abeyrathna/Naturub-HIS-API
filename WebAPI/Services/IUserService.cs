﻿using HISWebAPI.Controllers;
using HISWebAPI.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HISWebAPI.Services
{
   public interface IUserService
    {
        //bool IsAnExistingUser(string userName);
        bool IsValidUserCredentials(string userName, string password);
        LoginResult GetUserRole(string userName);
    }

    public class UserService : IUserService
    {
        private readonly IConfiguration _configuration;

        private readonly ILogger<UserService> _logger;
        private AccountDA objAccountDA;

        private readonly IDictionary<string, string> _users = new Dictionary<string, string>
        {
            { "test1", "password1" },
            { "test2", "password2" },
            { "admin", "securePassword" }
        };
        // inject your database here for user validation
        public UserService(ILogger<UserService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public bool IsValidUserCredentials(string userName, string password)
        {
            _logger.LogInformation($"Validating user [{userName}]");
            if (string.IsNullOrWhiteSpace(userName))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }


            objAccountDA = new AccountDA(_configuration);
            objAccountDA.GetUser(userName);

            DataTable dt = objAccountDA.GetUser(userName);
            if (dt.Rows[0]["Password"].Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }

            //return _users.TryGetValue(userName, out var p) && p == password;
        }

        //public bool IsAnExistingUser(string userName)
        //{
        //    return _users.ContainsKey(userName);
        //}

        public LoginResult GetUserRole(string userName)
        {
            //if (!IsAnExistingUser(userName))
            //{
            //    return string.Empty;
            //}

            LoginResult obj = new LoginResult();

            objAccountDA = new AccountDA(_configuration);
            objAccountDA.GetUser(userName);

            DataTable dt = objAccountDA.GetUser(userName);

            obj.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
            obj.FirstName = dt.Rows[0]["FirstName"].ToString();
            obj.LastName = dt.Rows[0]["LastName"].ToString();
            obj.Email = dt.Rows[0]["Email"].ToString();
            obj.IsAdmin = Convert.ToBoolean(dt.Rows[0]["IsAdmin"]);
            obj.ProfilePhoto = dt.Rows[0]["ProfilePhoto"].ToString();
            obj.UserGroupName = dt.Rows[0]["UserGroupName"].ToString();
            obj.UserGroupID = Convert.ToInt32(dt.Rows[0]["UserGroupID"]); 

            return obj; 
        }
    }

    public static class UserRoles
    {
        public const string Admin = nameof(Admin);
        public const string BasicUser = nameof(BasicUser);
    }
}
