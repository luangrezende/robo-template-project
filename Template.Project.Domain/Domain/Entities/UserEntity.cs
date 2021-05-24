﻿using Template.Project.Domain.Entities.Base;

namespace Template.Project.Domain.Domain.Entities
{
    public class UserEntity : IBaseEntity
    {
        public string UserID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
