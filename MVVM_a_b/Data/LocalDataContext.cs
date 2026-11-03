using MVVM_a_b.Model;

namespace MVVM_a_b.Data
{
    public static class LocalDataContext
    {
        public static List<Role> Roles { get; set; } = new List<Role>()
        {
            new Role(){ Id = 1, Name = "user"},
            new Role(){ Id = 2, Name = "meneger"},
            new Role(){ Id = 3, Name = "admin"},
        };
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User(){Id = 1, Login = "1", Password = "1", Role = Roles[0], Name = "name 1"},
            new User(){Id = 2, Login = "2", Password = "2", Role = Roles[1], Name = "name 2"},
            new User(){Id = 3, Login = "3", Password = "3", Role = Roles[2], Name = "name 3"},
        }; 
    }
}
