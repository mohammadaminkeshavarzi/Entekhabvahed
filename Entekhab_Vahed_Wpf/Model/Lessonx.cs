namespace Entekhab_Vahed_Wpf.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Lesson")]
    public partial class Lessonx
    {
        public Lessonx()
        {
            ChooseUnits = new HashSet<ChooseUnit>();
            Classes = new HashSet<Classx>();
            Scores = new HashSet<Scorex>();
        }

        [Key]
        public int lCode { get; set; }

        public string Name { get; set; }

        public int Vahed { get; set; }

        public int field_id { get; set; }

        public int prof_id { get; set; }

        public virtual ICollection<ChooseUnit> ChooseUnits { get; set; }

        public virtual ICollection<Classx> Classes { get; set; }

        public virtual Fieldx Field { get; set; }

        public virtual Professorx Professor { get; set; }

        public virtual ICollection<Scorex> Scores { get; set; }
    }
}
