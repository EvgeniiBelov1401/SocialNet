﻿using SocialNet.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace SocialNet.ViewModels.Account
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user)
        {
            User = user;
        }
        public List<User> Friends { get; set; }


    }
}
