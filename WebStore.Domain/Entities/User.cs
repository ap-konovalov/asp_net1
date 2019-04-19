using Microsoft.AspNetCore.Identity;

namespace WebStore.Domain.Entities
{
    public class User : IdentityUser
    {
        public const string AdminUserName = "admin";
        public const string DefaultAdminPassword = "admin";
        
        public const string RoleAdmin = "Administrator";
        public const string RoleUSer = "User";


    }

//    public class Role : IdentityRole
//    {
//        
//    }
}