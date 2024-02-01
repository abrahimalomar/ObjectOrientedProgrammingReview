using System.Collections.Generic;
using System.Text;

namespace Composition.Model
{
    public class Techer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> courses { get; set; } 
    }
}
