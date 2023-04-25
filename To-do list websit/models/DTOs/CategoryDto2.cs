using To_do_list_websit.models.mytask;

namespace To_do_list_websit.models.DTOs
{
    public class CategoryDto2
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TaskDto> tasks { get; set; }
    }
}
