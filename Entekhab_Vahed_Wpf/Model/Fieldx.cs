namespace Entekhab_Vahed_Wpf.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Field")]
    public partial class Fieldx
    {
        public Fieldx()
        {
            ChooseUnits = new HashSet<ChooseUnit>();
            Lessons = new HashSet<Lessonx>();
            Professors = new HashSet<Professorx>();
            Students = new HashSet<Studentx>();
            
        }
        [Key]
        public int FieldId { get; set; }

        public string FieldName { get; set; }

        public virtual ICollection<ChooseUnit> ChooseUnits { get; set; }

        public virtual ICollection<Lessonx> Lessons { get; set; }

        public virtual ICollection<Professorx> Professors { get; set; }

        public virtual ICollection<Studentx> Students { get; set; }
    }
}
