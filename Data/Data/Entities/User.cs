using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public string? Country { get; set; }
        public string? UserName { get; set; }
        public DateTime Registration { get; set; }
        public decimal Balance { get; set; }
        //public Int16 Advert { get; set; } //Count of advertisement
    }
}
