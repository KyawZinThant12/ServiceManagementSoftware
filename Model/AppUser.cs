using System.Collections.Generic;

namespace Model
{
    public class AppUser
    {
        public string userId { get; set; }
        public string pwd { get; set; }
        public string userName { get; set; }
        public UserLevel userLevel { get; set; }
        public bool inActive { get; set; }

        public IEnumerable<AppPermission> appPermissions { get; set; }
    }

    public enum UserLevel
    {
        User,
        Manager,
        Admin
    }
}
