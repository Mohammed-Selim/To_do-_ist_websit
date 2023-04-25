using System.ComponentModel.DataAnnotations;
using To_do_list_websit.models.categorys;
using To_do_list_websit.models.user;

namespace To_do_list_websit.models.DTOs
{
    public class TaskDto2
    {

        public int id { set; get; }
        public string name { set; get; }
        public string? description { set; get; }
        public DateTime? AssignDate { set; get; }

        [Range(1, 3)]
        public int states { get; set; }

        public int? Userid { set; get; }
        public UserDto user { set; get; }

        public int Categoryid { set; get; }
        public CategoryDto Category { set; get; }
    }
}
