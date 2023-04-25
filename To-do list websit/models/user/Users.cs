using To_do_list_websit.models.mytask;
using To_do_list_websit.models.user;

 namespace To_do_list_websit.models.user
{
    public class Users
    {
        public Users( string name, string email)
        {
            
            Name = name;
            Email = email;
            this.tasks = new List<tasks>();
        }
         public Users() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<tasks>? tasks { get; set; }
    }
}
