namespace Entekhab_Vahed_Wpf.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Professor")]
    public partial class Professorx
    {
        public Professorx()
        {
            ChooseUnits = new HashSet<ChooseUnit>();
            Classes = new HashSet<Classx>();
            Lessons = new HashSet<Lessonx>();
            Scores = new HashSet<Scorex>();
        }

        [Key]
        public int pCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Degree { get; set; }

        public int field_id { get; set; }

        public virtual ICollection<ChooseUnit> ChooseUnits { get; set; }

        public virtual ICollection<Classx> Classes { get; set; }

        public virtual Fieldx Field { get; set; }

        public virtual ICollection<Lessonx> Lessons { get; set; }

        public virtual ICollection<Scorex> Scores { get; set; }
    }
}
