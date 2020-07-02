﻿using StockApi.BO;
using StockApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApi.Converters
{
    public class UserConverter
    {
        public User Convert(UserBO bo)
        {
            User user = new User()
            {
                Email = bo.Email,
                Password = bo.Password,
                UserId = bo.Password,
                UserName = bo.UserName
            };
            return user;
        }

        public UserBO Convert(User user)
        {
            UserBO bo = new UserBO
            {
                UserName = user.UserName,
                UserId = user.UserId,
                Password = user.Password,
                Email = user.Email
            };
            return bo;
        }

        public List<UserBO> Convert(List<User> Users)
        {
            return Users.Select(x => Convert(x)).ToList();
        }

        public List<User> Convert(List<UserBO> UsersBo)
        {
            return UsersBo.Select(c => Convert(c)).ToList();
        }
    }
}
