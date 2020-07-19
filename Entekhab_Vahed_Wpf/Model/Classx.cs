namespace Entekhab_Vahed_Wpf.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Classx
    {
        [Key]
        public int classCode { get; set; }

        public string ClassName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Dates { get; set; }

        public int lesson_code { get; set; }

        public int prof_id { get; set; }

        public TimeSpan Times { get; set; }

        public string Makan { get; set; }

        public int capacity { get; set; }

        public virtual Lessonx Lesson { get; set; }

        public virtual Professorx Professor { get; set; }
    }
}
