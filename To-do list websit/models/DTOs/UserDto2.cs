using To_do_list_websit.models.mytask;

namespace To_do_list_websit.models.DTOs
{
    public class UserDto2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<TaskDto>? tasks { get; set; }
    }
}
