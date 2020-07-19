namespace Entekhab_Vahed_Wpf.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChooseUnit")]
    public partial class ChooseUnit
    {
        [Key]
        public int CUCode { get; set; }

        public int lesson_code { get; set; }

        public int prof_id { get; set; }

        public int stud_id { get; set; }

        public int field_id { get; set; }

        public int cUnit { get; set; }

        public virtual Fieldx Field { get; set; }

        public virtual Lessonx Lesson { get; set; }

        public virtual Professorx Professor { get; set; }

        public virtual Studentx Student { get; set; }
    }
}
