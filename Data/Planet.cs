using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPlanetas.Data
{
    public class Planet
    {
        public int Id { get; set; }
        public decimal Age { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Extra { get; set; }
        public string Images { get; set; }
        
    }
}
