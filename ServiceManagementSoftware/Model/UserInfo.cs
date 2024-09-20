using m = Model;

namespace ServiceManagementSoftware.Model
{
    public class UserInfo : m.AppUser
    {
        public byte[] rPwd { get; set; }
        public bool remember { get; set; }
    }
}
