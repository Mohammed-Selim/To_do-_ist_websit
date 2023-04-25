using System.Threading.Tasks;
using To_do_list_websit.models.mytask;

namespace To_do_list_websit.models.categorys
{
    public class Category
    {
        //public Category( string name)
        //{
           
        //    Name = name;
        //    this.tasks = new List<tasks>();
        //}
       // private Category() { }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<tasks> tasks { get; set; }
    }
}
