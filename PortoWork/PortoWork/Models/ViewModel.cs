using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortoWork.Models
{
    public class ViewModel
    {
        public IEnumerable<Service> service { get; set; }
        public IEnumerable<Project> project { get; set; }
        public IEnumerable<Blog> blog { get; set; }
    }
}