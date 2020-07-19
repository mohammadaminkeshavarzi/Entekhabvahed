namespace Entekhab_Vahed_Wpf.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Scorex
    {
        [Key]
        public int scCode { get; set; }

        public int prof_id { get; set; }

        public int lesson_code { get; set; }

        public int stud_id { get; set; }

        [Column("score")]
        public int score1 { get; set; }

        public int cUnit { get; set; }

        public virtual Lessonx Lesson { get; set; }

        public virtual Professorx Professor { get; set; }

        public virtual Studentx Student { get; set; }
    }
}
