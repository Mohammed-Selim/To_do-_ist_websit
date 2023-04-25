using System.ComponentModel.DataAnnotations;

namespace To_do_list_websit.models.DTOs
{
    public class TaskDto
    {

        public int id { set; get; }
        public string name { set; get; }
        public string? description { set; get; }
        public DateTime? AssignDate { set; get; }

        [Range(1, 3)]
        public int states { get; set; }
    }
}
