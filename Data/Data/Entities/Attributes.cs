using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Data.Entities
{
    public class Attributes
    {
        public int Id { get; set; }
        public Boolean? wasUsed { get; set; }
        public Boolean? isNew { get; set; }
        public string? Model { get; set; }
        //public string ownAtr { get; set; }
        //public string? Colors { get; set; }
        //private Color? _colors { get; set; }

        //public Product products { get; set; }
    }
}
