using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab_Vahed_Wpf.Model
{
    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
