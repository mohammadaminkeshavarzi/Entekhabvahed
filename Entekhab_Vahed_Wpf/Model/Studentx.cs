namespace Entekhab_Vahed_Wpf.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Student")]
    public partial class Studentx
    {
        public Studentx()
        {
            ChooseUnits = new HashSet<ChooseUnit>();
            Scores = new HashSet<Scorex>();
        }

        [Key]
        public int sCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public int NatCode { get; set; }

        public string Degree { get; set; }

        public int field_id { get; set; }

        public virtual ICollection<ChooseUnit> ChooseUnits { get; set; }

        public virtual Fieldx Field { get; set; }

        public virtual ICollection<Scorex> Scores { get; set; }
    }
}
