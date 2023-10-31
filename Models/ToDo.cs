using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_API_SampleProject.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public int TaskID { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
    }
}
