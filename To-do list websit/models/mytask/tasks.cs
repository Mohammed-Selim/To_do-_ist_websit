using System.ComponentModel.DataAnnotations;
using To_do_list_websit.models.categorys;
using To_do_list_websit.models.user;

namespace To_do_list_websit.models.mytask
{
    //public enum state
    //{
    //    Open, In_Progress, Done
    //}
    public class tasks
    {
        public tasks(string name, string? description, DateTime assignDate, int states,  Users? user=null,  Category? category=null)
        {
            this.name = name;
            this.description = description;
            this.AssignDate = assignDate;
            this.states = states;
            this.user = user;

            this.Category = category;
        }
        public tasks():this(null!, null!, DateTime.Now, 1,null!, null!) { }
        public int id { set; get; }
        public string name { set; get; }
        public string? description { set; get; }
        public DateTime? AssignDate { set; get; }

        [Range(1,3)]
        public int states { get; set; }

        public int? Userid { set; get; }
        public Users? user { set; get; }

        public int? Categoryid { set; get; }
        public Category? Category { set; get; }
    }
}
