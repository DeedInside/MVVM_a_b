namespace MVVM_a_b.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateOnly Age { get; set; }
        public Role Role { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Login} - {Role}";
        }
    }
}
